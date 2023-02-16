print("----- Bienvenue sur le fameux logiciel de Calculatrice -----")
print("----- Vous pouvez faire des opérations de base -----")
print("----- Choisissez une opération -----")
print("----- 1. Addition -----")
print("----- 2. Soustraction -----")
print("----- 3. Multiplication -----")
print("----- 4. Division -----")

while True:
    choix = input("----- Votre choix : ")
    if choix == "1":
        print("----- Vous avez choisi l'addition -----")
        nombre1 = input("----- Entrez le premier nombre : ")
        nombre2 = input("----- Entrez le deuxième nombre : ")
        print("----- Le résultat est : ", int(nombre1) + int(nombre2))
    elif choix == "2":
        print("----- Vous avez choisi la soustraction -----")
        nombre1 = input("----- Entrez le premier nombre : ")
        nombre2 = input("----- Entrez le deuxième nombre : ")
        print("----- Le résultat est : ", int(nombre1) - int(nombre2))
    elif choix == "3":
        print("----- Vous avez choisi la multiplication -----")
        nombre1 = input("----- Entrez le premier nombre : ")
        nombre2 = input("----- Entrez le deuxième nombre : ")
        print("----- Le résultat est : ", int(nombre1) * int(nombre2))
    elif choix == "4":
        print("----- Vous avez choisi la division -----")
        nombre1 = input("----- Entrez le premier nombre : ")
        nombre2 = input("----- Entrez le deuxième nombre : ")
        print("----- Le résultat est : ", int(nombre1) / int(nombre2))
    else:
        print("----- Vous n'avez pas choisi une opération valide -----")

