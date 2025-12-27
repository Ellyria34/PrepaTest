//Jour2 Semain 2
List<int> numbers = [2, 4, 1];      //→ true
//List<int> numbers = [2, 1, 3];      //→ false
//List<int> numbers = [2, 1];         //→ false
//List<int> numbers = [0, -2, 3];       //→ true
//List<int> numbers = [];               //→ false

Console.WriteLine("La liste contient-elle plus de nombres pairs que de nombres impairs?");
bool hasMoreEvensThanOdds = HasMoreEvensThanOdds(numbers);
if(hasMoreEvensThanOdds)
{
    Console.WriteLine("Oui, la liste contient plus de nombres pairs que de nombres impairs?");    
}
else
{
    Console.WriteLine("Non, la liste ne contient pas plus de nombres pairs que de nombres impairs?");
}

//Methods
static bool HasMoreEvensThanOdds(List<int> numbers)
{
    int evenCount  = 0;
    int oddCount = 0;

    if(numbers == null || numbers.Count == 0)
    {
        return false;
    }

    foreach(int n in numbers)
    {
        if(n % 2 == 0)
        {
            evenCount ++;
        }
            else
            {
                oddCount ++;
            }
        }
        return (evenCount  > oddCount);
}
