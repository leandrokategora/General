from random import random, sample
import random
import pandas as pd 

lower = 'abcdefghijklmnñopqrstuvwxyz'
upper = 'ABCDEFGHIJKLMNÑOPQRSTUVWXYZ'
numero = '1234567890'
simbol = '@#+*^<>}{][-_$%&/)(?!'
dir_pandas = 'C:/Users/Usuario/proyecto1/Proyecto_python_intermedio/{}'.format('contraseñas.csv')

all_ = lower + upper + numero + simbol
length = 16


password = "".join(random.sample(all_, length))

plataforma =  input("A que plataforma corresponde: ")

user = input("A que Usuario corresponde la contraseña: ")


dict_pass = {
    'Plataforma' :     [str(plataforma)],
    'Usuario' : [str(user)],
    'Contraseña' :    [str(password)]
}


df = pd.DataFrame(dict_pass)

cuenta = plataforma + ": " + user + "; " + password

pd.to_csv(dir_pandas, index=False)
# with open('./contraseñas.csv', "r+", encoding="utf-8") as f:
#     f.write(df)




print(cuenta)


# print('Your password is: ' + password)
