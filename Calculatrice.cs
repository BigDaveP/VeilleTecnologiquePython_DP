Console.WriteLine("----- Bienvenue sur le fameux logiciel de Calculatrice -----");
Console.WriteLine("----- Vous pouvez faire des opérations de base -----");
Console.WriteLine("----- Choisissez une opération -----");
Console.WriteLine("----- 1. Addition -----");
Console.WriteLine("----- 2. Soustraction -----");
Console.WriteLine("----- 3. Multiplication -----");
Console.WriteLine("----- 4. Division ----- \n");

while (true) {
    Console.Write("Votre choix : ");
    int reponse = int.Parse(Console.ReadLine());

    double nombre1 = 0;
    double nombre2 = 0;
    double resultat = 0;
    if (reponse == 1)
    {
        Console.WriteLine("----- Vous avez choisi l'addition -----");
        Console.Write("Entrez le premier nombre : ");
        nombre1 = double.Parse(Console.ReadLine());
        Console.Write("Entrez le deuxième nombre : ");
        nombre2 = double.Parse(Console.ReadLine());
        resultat = nombre1 + nombre2;
        Console.WriteLine("Le résultat est : " + resultat);

    }
    else if (reponse == 2)
    {
        Console.WriteLine("----- Vous avez choisi la soustraction -----");
        Console.Write("Entrez le premier nombre : ");
        nombre1 = double.Parse(Console.ReadLine());
        Console.Write("Entrez le deuxième nombre : ");
        nombre2 = double.Parse(Console.ReadLine());
        resultat = nombre1 - nombre2;
        Console.WriteLine("Le résultat est : " + resultat);
    }
    else if (reponse == 3)
    {
        Console.WriteLine("----- Vous avez choisi la multiplication -----");
        Console.Write("Entrez le premier nombre : ");
        nombre1 = double.Parse(Console.ReadLine());
        Console.Write("Entrez le deuxième nombre : ");
        nombre2 = double.Parse(Console.ReadLine());
        resultat = nombre1 * nombre2;
        Console.WriteLine("Le résultat est : " + resultat);
    }
    else if (reponse == 4)
    {
        Console.WriteLine("----- Vous avez choisi la division -----");
        Console.Write("Entrez le premier nombre : ");
        nombre1 = double.Parse(Console.ReadLine());
        Console.Write("Entrez le deuxième nombre : ");
        nombre2 = double.Parse(Console.ReadLine());
        resultat = nombre1 / nombre2;
        Console.WriteLine("Le résultat est : " + resultat);
    }
    else 
    {
        Console.WriteLine("Choix invalide...");
    }
}


