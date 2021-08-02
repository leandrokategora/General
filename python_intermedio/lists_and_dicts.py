def run():
    my_list = [1, "hello", True, 4.5]
    my_dict = {"firstname": "facundo", "lastname": "garcia",}

    my_super_list = [ 
        {"firstname": "Gabriel", "lastname": "Kategora"},
        {"firstname": "Yesica", "lastname": "De Matos"},
        {"firstname": "Mateo", "lastname": "Pedroso"},

    ]
    
    my_super_dict = {
        "lista_1": [1, 2, 3, 4, 5],
        "lista_2": [6, 7, 8, 9, 0],
        "lista_3": [10, 11, 12, "nada mas", True]
    }

    for key, value in my_super_dict.items():
        print(key, "-", value)


if __name__=='__main__':
    run()
