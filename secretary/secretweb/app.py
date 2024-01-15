from flask import Flask, render_template, request, redirect, url_for, flash, session
from flask_sqlalchemy import SQLAlchemy

app = Flask(__name__)
app.secret_key = 'qwerty1' # Установите ваш секретный ключ для сессии

# Конфигурация подключения к базе данных
app.config['SQLALCHEMY_DATABASE_URI'] = 'mssql+pyodbc://FOCUS\\SQLEXPRESS/secretary?driver=ODBC+Driver+17+for+SQL+Server?Trusted_Connection=yes'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False
db = SQLAlchemy(app)

# Определение модели для таблицы 'incorect'
class Incorect(db.Model):
    __tablename__ = 'incorect'
    id = db.Column(db.Integer, primary_key=True)
    login_account = db.Column(db.String(100))
    password_account = db.Column(db.String(100))
    FIO = db.Column(db.String(100))

@app.route('/')
def index():
    error_message = session.pop('error_message', None)
    return render_template('login.html', error_message=error_message)

@app.route('/login', methods=['POST'])
def login():
    username = request.form['username']
    password = request.form['password']

    user = Incorect.query.filter_by(login_account=username, password_account=password).first()
    if user:
        return redirect(url_for('dashboard', fio=user.FIO))
    else:
        session['error_message'] = 'Неверно введен логин или пароль'
        return redirect(url_for('index'))

@app.route('/dashboard')
def dashboard():
    fio = request.args.get('fio', '')
    return render_template('dashboard.html', fio=fio)

if __name__ == '__main__':
    app.run(debug=True)
