import numpy as np

from proyecto_ahorcado import list_1


with open("./excel.xlsb", "r", encoding="utf-8") as f:
    tensor = np.array([celda for celda in f])

# with open("./VerCheckinCheckout.csv", "r", encoding="UTF-8") as e:    
    # list2 = [line for line in e]
    # for line in e:
    #     list2.append(line)
# my_dictx= {i: i+1 for i in range(list2.len)}


def run():
    print(tensor)
    X = input("decea continuar?: ")
    if X == "si":

        for elemento in tensor:
            print(elemento[::-1])        
    elif X != "si":
        print("esta seguro?")
        X2 = input(": ")
        if X2 == "si":
            exit()
        else:
            for elemento in tensor:
                print(elemento[::-1])        
  
            
    else:
        print("Adios")
    # print(my_dictx)





if __name__=="__main__":
    run()
