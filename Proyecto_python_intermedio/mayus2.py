
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


