from os import name


def read():
    numbers = []
    with open("./numeros.txt", "r", encoding="utf-8") as f:
        for line in f:
            numbers.append(int(line))

    print(numbers)



def write():
    names = ["facundo", "miguel", "pepe", "christian"]
    with open("./names.txt", "w", encoding="utf-8") as f:
        for name in names:
            f.write(name)
            f.write("\n")
            print()


def run():
    read()
    write()
#necesito ver porque no sube esto al repositorio remoto




if __name__ == "__main__":
    run()
