from flask import Flask, request, json
import os
import smtplib
from email.mime.multipart import MIMEMultipart
from email.mime.text import MIMEText

app = Flask(__name__)
DB_FILE_NAME = '/user/src/app/shared_folder/users.txt'

def SendEmailMes(subject):
    smtpObj = smtplib.SMTP('smtp.gmail.com', 587)
    smtpObj.starttls()
    email ="valentain.sav99@gmail.com"
    password = "E3wcWFXqMN"
    smtpObj.login(email, password)
    msg = MIMEMultipart()
    msg['From'] = email
    msg['To'] = email
    msg['Subject'] = subject
    body = "Sent by REST"
    msg.attach(MIMEText(body, 'plain'))
    smtpObj.sendmail(email, email, msg.as_string())
    smtpObj.quit()

# curl -X GET localhost:5000/users/IsLoginFree?login=admin2
@app.route('/users/IsLoginFree', methods = ['GET'])
def isLoginFree():
    if not os.path.exists(DB_FILE_NAME):
        return json.dumps(True)

    with open(DB_FILE_NAME) as f:
        content = [x.strip() for x in f.readlines()]

    return json.dumps(request.args.get('login') not in content)

# curl -X POST localhost:5000/users/AddLogin -d "{\"login\": \"admin\"}" -H "Content-Type: application/json; charset=UTF-8"
@app.route('/users/AddLogin', methods = ['POST'])
def addLogin():
    login = str(json.loads(request.data)['login'])

    if os.path.exists(DB_FILE_NAME):
        with open(DB_FILE_NAME) as f:
            content = [x.strip() for x in f.readlines()]
        if login in content:
            return 'This login already exists', 400

    with open(DB_FILE_NAME, 'a' if os.path.exists(DB_FILE_NAME) else 'w') as f:
        f.write(login + '\n')

    return json.dumps(login)

@app.route('/misc/SendEmail', methods = ['POST'])
def SendEmail():
    subject = str(json.loads(request.data)['subject'])
    SendEmailMes(subject)
    return json.dumps(subject)
