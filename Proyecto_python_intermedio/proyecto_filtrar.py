from proyecto_ahorcado import list_1


with open("./excel.xlsb", "r", encoding="utf-8") as f:
    list1 = [celda for celda in f]

# with open("./VerCheckinCheckout.csv", "r", encoding="UTF-8") as e:    
    # list2 = [line for line in e]
    # for line in e:
    #     list2.append(line)
my_dictx= {i: i+1 for i in list2}


def run():
    print(list1[::-1])
    X = input("decea continuar?: ")
    if X == "si":

        for elemento in list1:
            print(elemento[::-1])        
    elif X != "si":
        print("esta seguro?")
        X2 = input(": ")
        if X2 == "si":
            exit()
        else:
            for elemento in list1:
                print(elemento[::-1])        
  
            
    else:
        print("Adios")
    # print(my_dictx)





if __name__=="__main__":
    run()
