# app.py

from flask import Flask, render_template, request, redirect, url_for, session
import pyodbc

app = Flask(__name__)
app.secret_key = 'qwerty1'

# Конфигурация соединения с базой данных
connection = pyodbc.connect(
    'Driver={SQL Server};'
    'server=FOCUS\\SQLEXPRESS;'
    'Database=secretary;'
    'Trusted_Connection=yes;'
)

# Модель для таблицы 'incorect'
class Incorect:
    def __init__(self, id, login_account, password_account, FIO):
        self.id = id
        self.login_account = login_account
        self.password_account = password_account
        self.FIO = FIO

# Модель для таблицы 'register'
class Register:
    def __init__(self, id, email, password):
        self.id = id
        self.email = email
        self.password = password


def execute_query(query, params=None, fetchone=False):
    cursor = connection.cursor()
    if params:
        cursor.execute(query, params)
    else:
        cursor.execute(query)

    if fetchone:
        result = cursor.fetchone()
    else:
        result = cursor.fetchall()

    cursor.close()
    return result


@app.route('/')
def index():
    error_message = session.pop('error_message', None)
    return render_template('login.html', error_message=error_message)


@app.route('/logout')
def logout():
    # Очистить сеанс пользователя
    session.clear()
    # Перенаправить на страницу авторизации
    return redirect(url_for('index'))


@app.route('/submit_request')
def submit_request():
    return render_template('form.html')


@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'POST':
        email = request.form.get('email')  # Используйте метод get, чтобы избежать KeyError
        password = request.form.get('password')

        if email and password:
            # Проверяем, есть ли пользователь с такой электронной почтой и паролем
            query = """
                SELECT r.id, r.email, r.password, i.FIO
                FROM register r
                JOIN Incorect i ON r.id = i.user_id
                WHERE r.email = ? AND r.password = ?
            """
            params = (email, password)

            user_data = execute_query(query, params, fetchone=True)

            if user_data:
                user = Register(*user_data[:3])  # Исключаем FIO из параметров, так как оно уже есть в Incorect
                fio = user_data[3]
                return redirect(url_for('personal_cabinet', email=user.email, fio=fio))
            else:
                session['error_message'] = 'Неверно введена электронная почта или пароль'
                return redirect(url_for('index'))

    return render_template('login.html', error_message=None)


@app.route('/personal_cabinet')
def personal_cabinet():
    fio = request.args.get('fio', '')
    email = request.args.get('email', '')

    # Получаем все поля заявок пользователя из таблицы Incorect
    requests_query = "SELECT * FROM Incorect WHERE user_id = (SELECT id FROM register WHERE email = ?)"
    requests_params = (email,)
    user_requests = execute_query(requests_query, requests_params)

    return render_template('personal_cabinet.html', fio=fio, email=email, user_requests=user_requests)


@app.route('/register', methods=['GET', 'POST'])
def register():
    if request.method == 'POST':
        try:
            # Получаем логин и пароль из формы
            login_user = request.form['login_user']
            password_user = request.form['password_user']

            cursor = connection.cursor()

            # Проверяем, есть ли пользователь с таким логином
            cursor.execute('SELECT * FROM register WHERE email = ?', (login_user,))
            existing_user = cursor.fetchone()

            if existing_user:
                # Если пользователь существует, сообщаем об этом
                return "Пользователь с таким логином уже существует. Пожалуйста, выберите другой логин."
            else:
                # Добавляем нового пользователя в базу данных
                cursor.execute('INSERT INTO register (email, password) VALUES (?, ?)', (login_user, password_user))
                connection.commit()

                # Авторизуем пользователя
                session['email'] = login_user

                return redirect(url_for('personal_cabinet'))

        except Exception as e:
            # Логируем ошибку для отладки
            print(f"Error during registration: {e}")

    return render_template('register.html')


if __name__ == '__main__':
    app.run(debug=True)
