def run():
    # squeres = []
    # for i in range(1, 101):
        # if i % 3 != 0:
            # squeres.append(i**2)
    # print(squeres)
   #nombre.....elemento... rango/origen....condicion..!
    squeres = [i**2 for i in range(1, 101) if i % 3 !=0]
    print(squeres)


    # dictionary = {}
    # for i in range(1, 101):
        # dictionary[i] = i**3
# 
    # print(dictionary)
    
    dictionary = {i: i**2 for i in range(1, 101) if i % 3 != 0}
    print(dictionary)


if __name__=='__main__':
    run()
