DATA = [
    {
        'name': 'Facundo',
        'age': 72,
        'organization': 'Platzi',
        'position': 'Technical Coach',
        'language': 'python',
    },
    {
        'name': 'Luisana',
        'age': 33,
        'organization': 'Globant',
        'position': 'UX Designer',
        'language': 'javascript',
    },
    {
        'name': 'Héctor',
        'age': 19,
        'organization': 'Platzi',
        'position': 'Associate',
        'language': 'ruby',
    },
    {
        'name': 'Gabriel',
        'age': 20,
        'organization': 'Platzi',
        'position': 'Associate',
        'language': 'javascript',
    },
    {
        'name': 'Isabella',
        'age': 30,
        'organization': 'Platzi',
        'position': 'QA Manager',
        'language': 'java',
    },
    {
        'name': 'Karo',
        'age': 23,
        'organization': 'Everis',
        'position': 'Backend Developer',
        'language': 'python',
    },
    {
        'name': 'Ariel',
        'age': 32,
        'organization': 'Rappi',
        'position': 'Support',
        'language': '',
    },
    {
        'name': 'Juan',
        'age': 17,
        'organization': '',
        'position': 'Student',
        'language': 'go',
    },
    {
        'name': 'Pablo',
        'age': 32,
        'organization': 'Master',
        'position': 'Human Resources Manager',
        'language': 'python',
    },
    {
        'name': 'Lorena',
        'age': 56,
        'organization': 'Python Organization',
        'position': 'Language Maker',
        'language': 'python',
    },
]



def run():
    all_python_devs = [worker["name"] for worker in DATA if worker["language"] == "python"]
    all_platzi_worker = [worker["name"] for worker in DATA if worker["organization"] == "Platzi"]
    for worker in all_python_devs, all_platzi_worker:
        print(worker)
        
    platzi_workers = list(filter(lambda worker: worker["organization"] == "Platzi", DATA))
    
    platzi_workers = list(map(lambda worker: worker["name"], platzi_workers))

    print(platzi_workers)

    #esta modificacion es solo para ver si puedo hacer un push desde la notebook sony
    #esta modificacion es solo para ver si puedo hacer un push desde la maquina del trabajo
    #esta modificacion es solo para ver si puedo hacer un cambio desde github y bajarlo con pull
    #esta modificacion es para ver si funciona mi llave SSH
    #cool!!! parece que si funciono
    
if __name__=='__main__':
    run()
