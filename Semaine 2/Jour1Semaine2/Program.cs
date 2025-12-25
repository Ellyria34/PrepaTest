//Jour1 Semaine 2
using System.ComponentModel;

//List<int> numbers = [1, 2, 2, 3];
//List<int> numbers = [1, 2, 3, 3];
//List<int> numbers = [1, 2, 3];
//List<int> numbers = [5];
List<int> numbers = [];

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

