from os import name 
from random import random

# def read():
#     numbers = []
#     with open("./numeros.txt", "r", encoding="utf-8") as f:
#         for line in f:
#             numbers.append(int(line))

#     print(numbers)



# def write():
#     names = ["facundo", "miguel", "pepe", "christian"]
#     with open("./names.txt", "w", encoding="utf-8") as f:
#         for name in names:
#             f.write(name)
#             f.write("\n")
#             print()

def list_1():
    lista_de_palabras = []
    with open("./data.txt", "r", encoding="utf-8") as f:
        for line in f:
            lista_de_palabras.append(line)

    print(lista_de_palabras)
    
def palabra(a):
    a = 


def run():
    list_1()
    




if __name__ == "__main__":
    run()
