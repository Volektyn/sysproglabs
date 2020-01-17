import mysql.connector
import datetime
import re

db = mysql.connector.connect(host = '127.0.0.1',user = 'root',passwd = 'dimaisgay35',db = 'Apteka')
variant = input('1 - first table, 2 - second table, 3 - join tables, exit - to exit ')
while(variant != 4):
    cur3 = db.cursor()
    cur3.execute("Select Count(*) from Scope_Of_Drug_Using")
    Count = cur3.fetchall()
    cur1 = db.cursor()
    cur2 = db.cursor()
    print(variant)
    if variant == '1':
        cur1.execute("Select * From Scope_Of_Drug_Using")
        for row in cur1.fetchall():
            print(row)
    elif variant == '2':
        cur1.execute("Select * From Drug_Category")
        for row in cur1.fetchall():
            print(row)
    elif variant == '3':
        cur1.execute("Select * From Scope_Of_Drug_Using inner join Drug_Category on Scope_Of_Drug_Using.Category_ID = Drug_Category.Category_ID")
        for row in cur1.fetchall():
            print(row)
    elif variant == '4':
        break
    else:
        print('Incorrect Input')
    variant = input('1 - first table, 2 - second table, 3 - join tables, 4 - to exit ')


db.close()
