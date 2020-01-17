from flask import Flask
from flask_spyne import Spyne
from spyne.protocol.soap import Soap11
from spyne.model.primitive import Unicode, Integer
from spyne.model.complex import Iterable
import os
import smtplib
from email.mime.text import MIMEText
from email.mime.multipart import MIMEMultipart

app = Flask(__name__)
spyne = Spyne(app)
DB_FILE_NAME = '/user/src/app/shared_folder/users.txt'

'''
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:som="tns">
	<soapenv:Body>
		<som:isLoginFree>
			<som:login>Andrii</som:login>
		</som:isLoginFree>
	</soapenv:Body>
</soapenv:Envelope>
'''

'''
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:som="tns">
	<soapenv:Body>
		<som:addLogin>
			<som:login>Andrii</som:login>
		</som:addLogin>
	</soapenv:Body>
</soapenv:Envelope>
'''

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
    body = "Sent by SOAP"
    msg.attach(MIMEText(body, 'plain'))
    smtpObj.sendmail(email, email, msg.as_string())
    smtpObj.quit()


class SomeSoapService(spyne.Service):
    __service_url_path__ = '/soap/someservice'
    __in_protocol__ = Soap11(validator='lxml')
    __out_protocol__ = Soap11()

    @spyne.srpc(str, _returns=bool)
    def isLoginFree(login):
        if not os.path.exists(DB_FILE_NAME):
            return True

        with open(DB_FILE_NAME) as f:
            content = [x.strip() for x in f.readlines()]

        return login not in content

    @spyne.srpc(str, _returns=str)
    def addLogin(login):
        if os.path.exists(DB_FILE_NAME):
            with open(DB_FILE_NAME) as f:
                content = [x.strip() for x in f.readlines()]
            if login in content:
                return 'This login already exists'

        with open(DB_FILE_NAME, 'a' if os.path.exists(DB_FILE_NAME) else 'w') as f:
            f.write(login + '\n')

        return login
    
    @spyne.srpc(str, _returns=bool)      
    def SendEmail(subject):
        try:
            SendEmailMes(subject)
            return True
        except:
            return False

if __name__ == '__main__':
    app.run(host = '0.0.0.0', port=5000)