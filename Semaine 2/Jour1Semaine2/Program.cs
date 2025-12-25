//Jour1 Semaine 2
using System.ComponentModel;
using System.Globalization;

int min = 4;
int max = 9;
List<int> numbers = [];
//List<int> numbers = [1, 2, 2, 3];
//List<int> numbers = [1, 2, 3, 3];
//List<int> numbers = [1, 2, 3];
//List<int> numbers = [5];
//List<int> numbers = [];

//Exercice 1
Console.WriteLine("Test révision - Est ce que la liste contient deux nombres consécutifs identiques ?");
bool hasConsecutiveDuplicates = HasConsecutiveDuplicates(numbers);
if (hasConsecutiveDuplicates)
{
    Console.WriteLine("Oui, il y a au moins deux nombres consécutifs.");    
}
else
{
    Console.WriteLine("Non, il n'y a pas deux nombres consécutifs.");    
}

//Exercice 2
Console.WriteLine($"Est ce que la liste contient au moins un nombre compris entre {min} et {max}?");

if(numbers != null && numbers.Count > 0)
{
    bool containsBettween = ContainsBettween(numbers, min, max);
    if (containsBettween)
    {
        Console.WriteLine($"Oui, la liste contient au moins un nombre compris entre {min} et {max}.");
    }
    else
    {
        Console.WriteLine($"Non, la liste ne contient aucun nombre compris entre {min} et {max}.");
    }
}
else
{
    Console.WriteLine($"Non, la liste ne contient aucun nombre compris entre {min} et {max}.");
}

//Methods
static bool HasConsecutiveDuplicates(List<int> numbers)
{
    for (int i = 0; i < numbers.Count-1; i++)
    {
        if(numbers[i] == numbers[i+1])
        {
            return true;
        }
    }
    return false;
}

static bool ContainsBettween(List<int> numbers, int min, int max)
{
    for(int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] < max && numbers[i] > min)
        {
            return true;
        }
    }
    return false;
}

