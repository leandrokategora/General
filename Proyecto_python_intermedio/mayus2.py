


list_5 = []
def run():
    with open("./names.txt", "r", encoding="utf-8") as f:
        for line in f:
            list_5.append(line)

        for x in list_5:
            print(x.upper())




if __name__=="__main__":
    run()

