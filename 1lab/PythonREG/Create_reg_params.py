#5. Створіть в операційній системі Windows нову гілку реєстру:
#HKLM/Software/<ВАШЕ ПРІЗВИЩЕ ЛАТИНИЦЕЮ>
#
#Напишіть мовою Python консольну програму, яка в цій гілці створює три параметра з іменами P1, P2, P3 з типами String,
#  DWORD(32bit), DWORD(32bit).
#Запишіть в параметр P1 значення "Спеціальність КІ", в параметр P2 - одне шістнадцяткове число 2A4BCEDE,
#  в параметр P3 - одне десяткове число 709611230.
import winreg
import binascii
key = winreg.OpenKey(winreg.HKEY_LOCAL_MACHINE, r"SOFTWARE\\", 0, winreg.KEY_READ | winreg.KEY_WOW64_64KEY)
subkey = winreg.CreateKey(key, r'Shcherban\\')
winreg.SetValueEx(subkey,'P1', 0, winreg.REG_SZ, 'Спеціальність КІ')
winreg.SetValueEx(subkey,'P2', 0, winreg.REG_MULTI_SZ, ['{:x}'.format(0x2A),'{:x}'.format(0x4B),'{:x}'.format(0xCE),'{:x}'.format(0xDE)])
winreg.SetValueEx(subkey,'P3', 0, winreg.REG_DWORD, 709611230)

#import winreg
#import binascii
#key = winreg.OpenKey(winreg.HKEY_LOCAL_MACHINE, r"SOFTWARE\\", 0, winreg.KEY_READ | winreg.KEY_WOW64_64KEY)
#subkey = winreg.CreateKey(key, r'Shcherban\\')
#winreg.SetValueEx(subkey,'P1', 0, winreg.REG_SZ, 'Студент кафедри')
#winreg.SetValueEx(subkey,'P2', 0, winreg.REG_BINARY, binascii.unhexlify('2A'), binascii.unhexlify('4B'),
#                  binascii.unhexlify('CE'),binascii.unhexlify('DE'))
#winreg.SetValueEx(subkey,'P3', 0, winreg.REG_DWORD, binascii.unhexlify('2A4BCEDF'))


#Запишіть в параметр P1 значення "Студент кафедри",
#в параметр P2 - чотири шістнадцяткові числа 2A, 4B, CE, DF,
#в параметр P3 - одне шістнадцяткове число 2A4BCED

