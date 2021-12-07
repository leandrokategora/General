def make_repeater_of(n):
    def repeater(string):
        assert type(string) == str, "solo se pueden ingresar strings"
        return string * n 
    return repeater





def 








def run():
    repeat_5 = make_repeater_of(5)
    print(repeat_5(input("ingrese una frase: ")))
    
if __name__=="__main__":
    run()
