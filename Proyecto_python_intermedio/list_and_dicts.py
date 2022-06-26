def run():
    my_list = [1, "hello", True, 4.5]
    my_dict = {"firstname": "Facundo", "lastname": "Garcia"}


    super_list = [
        {"firstname": "Facundo", "lastname": "Garcia"},
        {"firstname": "Miguel", "lastname": "Torres"},
        {"firstname": "Pepe", "lastname": "Rodelo"},
        {"firstname": "Luciano", "lastname": "Martingaste"},
        {"firstname": "Jose", "lastname": "Garcia"}
    ]

    super_dict = {
        "natural_nums":[1,2,3,4,5,6,7,8,9,0],
        "integer_nums":[-1,-2,0,1,2],
        "floating_nums":[1.2, 2.5, 3.1, 4.6, 5.6]
    }
    for key, value in super_dict.items():
        print(key, "-", value)
if __name__=='__main__':
    run()

defauldict= license