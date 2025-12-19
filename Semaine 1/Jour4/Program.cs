using System.Security;

List<int> numbers = [5, 2, -4, 6, 0, 3];

if(numbers != null && numbers.Count > 0)
{
    //Exercice 1
    Console.WriteLine("Exercice 1 - Retourner la somme des nombres pairs strictement positifs.");
    int sumPositiveEven = SumPositiveEven(numbers);
    Console.WriteLine($"La somme des nombre strictement positif est égale à : {sumPositiveEven}");

}
else
{
    Console.WriteLine("La list de nombre est vide.");
}

static int SumPositiveEven (List<int> numbers)
{
    int result = 0;

    foreach (int n in numbers)
    {
        if (n > 0 && n % 2 == 0)
        {
            result = result + n;
        }
    }
    return result;
}