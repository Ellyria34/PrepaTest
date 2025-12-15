using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Transactions;

List<int> numbers = [5,10,25,50,-80,2,55,4];
int value = 2;

if(numbers != null && numbers.Count()>0)
{
    //Exercice 1
    Console.WriteLine("Exercice 1 - Donner le nombre le plus grand :");
    int max = FindMax(numbers);
    Console.WriteLine($"Le nombre le plus grand de la liste est : {max}");

    //Exercice 2
    Console.WriteLine($"Exercice 2 - Le chiffre {value} est-il dans la liste");
    bool containValue = ContainValue(numbers, value);
    if(containValue == true)
    {
        Console.WriteLine($"Le nombre {value} est bien dans la liste");
    }
    else 
    {
        Console.WriteLine($"Le nombre {value} n'est bien dans la liste");
    }
}
else
{
    Console.WriteLine("La liste est vide on ne peut pas répondre à l'exercice 1 et 2");
}

// Exercice 3 - Test Final:
List<int> listNumbers = [1, 5, 10, 3, 8];
int limit = 4;

if(listNumbers != null && listNumbers.Count()>0)
{
    Console.WriteLine($"Exercice 3 (Test final) - Combien de nombres sont strictement supérieurs à {limit}");
    int result2 = CountGreaterThan(listNumbers, limit);
    Console.WriteLine($"Il y {result2} nombres qui sont strictement supérieurs à {limit}");
}
else
{
    Console.WriteLine("La liste est vide");
}

//Functions : 
static int FindMax(List<int> numbers){
    int max = numbers[0];
    foreach(int n in numbers)
    {
        if (n > max)
        {
            max = n;
        }
        // Console.WriteLine($"n = {n}, max = {max}");
    }
    return max;
}


static bool ContainValue(List<int> numbers, int value)
{
    foreach (int n in numbers)
    {
        if(n == value)
        {
            return true;
        }
    }
    return false;
}

static int CountGreaterThan(List<int> listNumbers, int limit)
{
    int result = 0;
    foreach (int n in listNumbers)
    {
        if(n > limit)
        {
            result ++;
        }
    }
    return result;
}