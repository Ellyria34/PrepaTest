using System.IO.Pipelines;

List<int> numbers = [5, -2, 10, 0, -3, 4];
int min = 3;
int max = 9;

if(numbers != null && numbers.Count>0)
{
    // Exercice 1 :
    //résultat attendu = 19 (5 + 10 + 4)
    Console.WriteLine($"Exercice 1 - Calculer la somme des nombres positifs de la liste numbers :");
    int sumPositiveResult = SumPositive(numbers);
    Console.WriteLine($"La somme des nombres positifs de la liste numbers est égale à : {sumPositiveResult}.");

    // Exercice 2 :
    Console.WriteLine($"Exercice 2 - Retourner le premier nombre strictement négatif de la liste :");
    int firstNegative = FirstNegative(numbers);
    if (firstNegative != 0)
    {
        Console.WriteLine($"Le premier nombre strictement négatif est : {firstNegative}.");
    }
    else
    {
        Console.WriteLine($"Il n'y a pas de nombre negatif dans cette liste.");
    }

    //Exercice 3 :
    Console.WriteLine($"Exercice 3 - Retourner true si tous les nombres sont strictement positifs :");
    bool allIsPositive = AllPositive(numbers);
    if(allIsPositive)
    {
        Console.WriteLine($"True. Tous les nombres de la listes sont positifs");

    }
    else
    {
        Console.WriteLine($"False. Les nombres de la listes ne sont pas tous positifs");
    }

    //Exercice 4 :
    Console.WriteLine($"Exercice 4 - Retourner true si au moins un nombre est pair :");
    bool firstPair = FirstPair(numbers);
    if(firstPair)
    {
        Console.WriteLine($"True. Il y a au moins un nombre est pair");
    }
    else
    {
        Console.WriteLine($"False. Aucun nombre n'est pair");
    }

    //Test Final du jour
    Console.WriteLine($"Test final - Combien de nombres dans une liste sont strictement supérieurs à {min} et strictement inférieurs à {max} ?");
    int nbrResult = CountBetween(numbers, min, max);
    Console.WriteLine($"Il y a {nbrResult} nombre(s) compris entre {min} et {max}.");
}
else
{
    int sumPositiveResult = 0;
    Console.WriteLine($"La liste est vide. Le résultat = {sumPositiveResult}.");
}

//Methodes
static int SumPositive(List<int> numbers)
{
    int result = 0;
    foreach(int n in numbers)
    {
        if (n > 0)
        {
            result = result + n; 
        }
    }
    return result;
}

static int FirstNegative(List<int> numbers)
{
    foreach(int n in numbers)
    {
        if (n < 0)
        {
            return n;
        }
    }
    return 0;
}

static bool AllPositive(List<int> numbers)
{
    foreach (int n in numbers)
    {
        if (n <= 0)
        {
            return false;
        }
    }
    return true;
}

static bool FirstPair(List<int> numbers)
{
    foreach(int n in numbers)
    {
        if (n % 2 == 0)
        {
            return true;
        }
    }
    return false;
}

static int CountBetween(List<int> numbers, int min, int max)
{
    int result = 0;
    foreach (int n in numbers)
    {
        if (min < n && max > n)
        {
            result ++;
        }
    }
    return result; 
}