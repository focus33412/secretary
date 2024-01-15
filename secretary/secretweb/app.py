# app.py

from flask import Flask, render_template, request, redirect, url_for, session
import pyodbc

app = Flask(__name__)
app.secret_key = 'qwerty1'

connection = pyodbc.connect(
    'Driver={SQL Server};'
    'server=FOCUS\\SQLEXPRESS;'
    'Database=secretary;'
    'Trusted_Connection=yes;'
)

# Определение модели для таблицы 'incorect'
class Incorect:
    def __init__(self, id, login_account, password_account, FIO):
        self.id = id
        self.login_account = login_account
        self.password_account = password_account
        self.FIO = FIO

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

@app.route('/login', methods=['POST'])
def login():
    username = request.form['username']
    password = request.form['password']

    query = "SELECT * FROM incorect WHERE login_account = ? AND password_account = ?"
    params = (username, password)
    
    user_data = execute_query(query, params, fetchone=True)

    if user_data:
        user = Incorect(*user_data[1:5])  # передайте только нужные элементы кортежа
        return redirect(url_for('personal_cabinet', fio=user.FIO))
    else:
        session['error_message'] = 'Неверно введен логин или пароль'
        return redirect(url_for('index'))

@app.route('/personal_cabinet')
def personal_cabinet():
    fio = request.args.get('fio', '')
    return render_template('personal_cabinet.html', fio=fio.encode('utf-8'))




if __name__ == '__main__':
    app.run(debug=True)
