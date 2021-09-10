from functools import reduce

def run():
    #FILTER sirve para filtrar datos de un iterable y retornarlos en un nuevo iterable
    my_list = [x for x in range(1, 111)
    ]
    odd = list(filter(lambda x: x % 2 != 0, my_list))
    print("FILTER: ", odd)
    
    #MAP sirve para "procesar" los elementos del iterable segun un criterio y retornarlos dentro de un nuevo iterable
    squares = list(map(lambda x: x**2, my_list))
    print("MAP: ", squares)


    #REDUCE sirve para multiplicar los elementos del iterable, hasta obtener un solo elemento que se retorna en un nuevo iterable
    all_multiplied = reduce(lambda a, b: a * b, my_list)
    print("REDUCE: ", all_multiplied)


if __name__ == '__main__':
    run()    