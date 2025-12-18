
List<int> numbers = [5, -2, 10, 0, -3, 4];

if(numbers != null && numbers.Count() > 0)
{
    //Exercice 1
    Console.WriteLine("Exercice 1 - Retourner l’indice du premier nombre négatif.");
    int indexOfFirstNegative = IndexOfFirstNegative(numbers);
    Console.WriteLine($"l'indice du premier nombre négatif est : {indexOfFirstNegative}");

}
else
{
    Console.WriteLine("La list de nombre est vide.");
}


static int IndexOfFirstNegative(List<int> numbers)
{
    for(int i = 0; i < numbers.Count(); i++)
    {
        if (numbers[i] < 0)
        {
            return i;
        }
    }
    return -1;
}