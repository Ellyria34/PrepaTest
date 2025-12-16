using System.IO.Pipelines;

List<int> numbers = [5, -2, 10, 0, -3, 4];

if(numbers != null && numbers.Count()>0)
{
    // Exercice 1 :
    //résultat attendu = 19 (5 + 10 + 4)
    Console.WriteLine($"Exercice 1 - Calculer la somme des nombres positifs de la liste numbers");
    int sumPositiveResult = SumPositive(numbers);
    Console.WriteLine($"La somme des nombres positifs de la liste numbers est égale à : {sumPositiveResult}.");

    // Exercice 2 :
    Console.WriteLine($"Exercice 2 - Retourner le premier nombre strictement négatif de la liste.");
    int firstNegative = FirstNegative(numbers);
    if (firstNegative != 0)
    {
        Console.WriteLine($"Le premier nombre strictement négatif est : {firstNegative}.");
    }
    else
    {
        Console.WriteLine($"Il n'y a pas de nombre negatif dans cette liste.");
    }
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
