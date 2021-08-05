def run():
    # squares = []
    # for i in range(1, 101):
    #     if i % 3 != 0:
    #         squares.append(i**2)
    squares = [i**2 for i in range(1, 101) if i % 3 != 0]

    print("mi lista es:", squares )

    my_dict = {}

    # for i in range(1, 101):
    #     if i % 3 != 0:
    #         my_dict[i] = i**3

    my_dict = {i: i**3 for i in range(1, 101) if i % 3 != 0}
    

    print("mi diccionario es: ", my_dict)        


if __name__ == '__main__':
    run()
