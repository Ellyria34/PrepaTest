
//List<int> numbers = [5, -2, 10, 0, -3, 4];
List<int> numbers = [-3, -2, 0, 3, 5, 10];


if(numbers != null && numbers.Count > 0)
{
    //Exercice 1
    Console.WriteLine("Exercice 1 - Retourner l’indice du premier nombre négatif.");
    int indexOfFirstNegative = IndexOfFirstNegative(numbers);
    Console.WriteLine($"L'indice du premier nombre négatif est : {indexOfFirstNegative}");

    //Exercice 
    Console.WriteLine("Exercice 2 - Compter combien de nombres sont strictement supérieurs à leur indice.");
    int countGreaterThanIndex = CountGreaterThanIndex(numbers);
    Console.WriteLine($"Il y a {countGreaterThanIndex} strictement supérieurs à l'indice.");
}
else
{
    Console.WriteLine("La list de nombre est vide.");
}

//Test Final J3
Console.WriteLine("Test final J3 - Écrire une méthode qui retourne true si la liste est strictement croissante.");
bool isStrictlyIncreasing = IsStrictlyIncreasing(numbers);
if (isStrictlyIncreasing)
{
    Console.WriteLine("La liste est strictement croissante");
}
else
{
    Console.WriteLine("La liste n'est pas strictement croissante");
}



//Methods
static int IndexOfFirstNegative(List<int> numbers)
{
    for(int i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] < 0)
        {
            return i;
        }
    }
    return -1;
}

static int CountGreaterThanIndex(List<int> numbers)
{
    int countGreaterThanIndex = 0;

    for(int i = 0; i < numbers.Count; i++)
    {
        if(i < numbers[i])
        {
            countGreaterThanIndex ++;
        }
    }
    return countGreaterThanIndex;
}

static bool IsStrictlyIncreasing(List<int> numbers)
{
    for (int i = 0; i < numbers.Count -1; i++)
    {
        if (numbers[i] >= numbers[i+1])
        {
            return false;
        }
    }
    return true;
}