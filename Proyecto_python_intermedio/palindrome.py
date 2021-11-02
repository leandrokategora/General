def is_palindrome(string: str) -> bool:
    string = string.replace(" ", "").lower()
    return string == string[::-1]



def run():
    string = input("ingrese una palabra: " )
    print(is_palindrome(string))
if __name__=="__main__":
    run()