from proyecto_ahorcado import list_1


with open("./data.txt", "r", encoding="utf-8") as f:
    list1 = [palabra for palabra in f]

with open("./VerCheckinCheckout2.csv", "r", encoding="UTF-8") as e:    
    list2 = [line for line in e]
    # for line in e:
    #     list2.append(line)
my_dictx= {i: i+1 for i in list2}


def run():
    # print(list2
    for elemento in list2[1::]:
        print(elemento)        
    # print(my_dictx)





if __name__=="__main__":
    run()
