<<<<<<< HEAD

algo = []


def run():
    with open("./names.txt", "r", encoding="utf-8") as f:
        for line in f:
            algo.append(line)

        for palabra in algo():
            palabra = palabra.upper()
            print(palabra)


if __name__=="__main__":
    run()


=======



list_5 = []
def run():
    with open("./names.txt", "r", encoding="utf-8") as f:
        for line in f:
            list_5.append(line)

        for x in list_5:
            print(x.upper())




if __name__=="__main__":
    run()

>>>>>>> e981be22f60c651da2f16434c50986d7d9b70f5d
