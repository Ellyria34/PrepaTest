Console.WriteLine("Jour 7");

//List<int> numbers = [5, 4, 3, 1];
List<int> numbers = [5, 10];

//Exercice Révision
Console.WriteLine("Partie A - Test de révision");
Console.WriteLine("Montrer si la liste est strictement décroissantes.");
bool isStrictlyDecreasing = IsStrictlyDecreasing(numbers);

if(isStrictlyDecreasing)
{
    Console.WriteLine("Oui la liste est strictement décroissantes.");    
}
else
{
    Console.WriteLine("Non la liste est strictement décroissantes.");
}


//Exercice nouveau pattern
Console.WriteLine("Partie B - Nouveau pattern");
Console.WriteLine("Montrer si la moyenne des nombres STRICTEMENT positifs de la liste est STRICTEMENT supérieure à 10.");
bool averagePositiveGreaterThanTen = AveragePositiveGreaterThanTen(numbers);
if(averagePositiveGreaterThanTen)
{
    Console.WriteLine("Oui la moyenne des nombres STRICTEMENT positifs de la liste est STRICTEMENT supérieure à 10.");    
}
else
{
    Console.WriteLine("Non la moyenne des nombres STRICTEMENT positifs de la liste est STRICTEMENT supérieure à 10.");
}


//Methods
static bool IsStrictlyDecreasing(List<int> numbers)
{
    for(int i = 0; i < numbers.Count - 1; i++)
    {
        if (numbers[i] <= numbers[i + 1])
        {
            return false;
        }
    }
    return true;
}

static bool AveragePositiveGreaterThanTen(List<int> numbers)
{
    int countNumber = 0;
    int sum = 0;
    int average = 0;

    foreach(int n in numbers)
    {
        if(n > 0)
        {
            sum = sum + n;
            countNumber ++;
        }
    }

    if(countNumber!=0)
    {
        average = sum/countNumber;
    }
    
    if(average > 10)
    {
        return true;
    }
    return false;
}


