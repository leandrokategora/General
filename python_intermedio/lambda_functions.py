def run():

    #nombre de la variable: variable que identifica a la funcion, palindrome.
    # palindrime seria un objeto o variable que recibe como parametro a la funcion de adentro 
    #palabra clave: lambda
    #argumento: string, accion: string = string dado vuelta?
    #esto deberia retornar un valor true o false, para cada 
    # string ingresada como parametro a a lavariable palindrome 
    # que se utiliza como identificador y arguemnto de la funcion 
    palindrome = lambda string: string == string[::-1]
    print(palindrome(input("ingrese una palabra:")))
 

if __name__=='__main__':
    run()