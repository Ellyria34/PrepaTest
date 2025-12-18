
List<int> numbers = [5, -2, 10, 0, -3, 4];

if(numbers != null && numbers.Count > 0)
{
    //Exercice 1
    Console.WriteLine("Exercice 1 - Retourner l’indice du premier nombre négatif.");
    int indexOfFirstNegative = IndexOfFirstNegative(numbers);
    Console.WriteLine($"l'indice du premier nombre négatif est : {indexOfFirstNegative}");

    //Exercice 
    Console.WriteLine("Exercice 1 - Compter combien de nombres sont strictement supérieurs à leur indice..");
    int countGreaterThanIndex = CountGreaterThanIndex(numbers);
    Console.WriteLine($"Il y a {countGreaterThanIndex} strinctement supérieurs à l'indice.");
}
else
{
    Console.WriteLine("La list de nombre est vide.");
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