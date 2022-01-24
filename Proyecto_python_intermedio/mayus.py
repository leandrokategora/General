

def run():
    with open("./names.txt", "r", encoding="utf-8") as f:
        for line in f:
            print(line.upper())


if __name__=="__main__":
    run()


