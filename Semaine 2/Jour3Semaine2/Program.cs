//Jour3 Semaine2
List<int> numbers = [5, 10, -2];
int numberRef = 1;

//Exercice 1
Console.WriteLine($"Combien de fois retrouve-t-on le nombre \"{numberRef}\" dans la liste de nombres ?");
int countOccurrences = CountOccurrences(numbers, numberRef);
Console.WriteLine($"La valeur {numberRef} est présente {countOccurrences} fois dans la liste.");

//Exercice 2
Console.WriteLine($"Calculer la moyenne des nombres strictement positif de la liste.");
double averageOfPositive = AverageOfPositive(numbers);
Console.WriteLine($"La moyenne des nombres strictement positif est égale à : {averageOfPositive}");

//Methods
static int CountOccurrences(List<int> numbers, int value)
{
    int countOccurrences = 0;
    foreach(int n in numbers)
    {
        if(n == value)
        {
            countOccurrences ++;
        }
    }
    return countOccurrences;
}

static double AverageOfPositive(List<int> numbers)
{
    double sum = 0;
    double countNumbers = 0;
    
    foreach(int n in numbers)
    {
        if(n > 0)
        {
            sum = sum + n;
            countNumbers ++;
        }
    }
    
    if(countNumbers == 0)
    {
        return 0;
    }    
    else 
    {
        return sum/countNumbers;
    }
}
