//Jour 6

//Partie A : Test révision
using System.ComponentModel;

Console.WriteLine("Partie A - Test Révision : Écrire une méthode qui retourne le plus petit nombre STRICTEMENT positif commun aux deux listes.");
List<int> listA = [1, 3, 5];
List<int> listB = [2, 3, 4, 5];
// List<int> listA = [-1, -2];
// List<int> listB = [1, 2];
if(listA != null && listB != null && listA.Count() > 0 && listB.Count() > 0)
{
    int minCommonPositive = MinCommonPositive(listA, listB);
    Console.WriteLine($"{minCommonPositive} est plus petit nombre positif contenu dans la listA et listB.");
}
else
{
    Console.WriteLine("Une des deux listes est vide");
}

static int MinCommonPositive(List<int> listA, List<int> listB)
{
    int minCommonPositive = -1;
    foreach(int nA in listA)
    {
        if(nA > 0)
        {
            foreach(int nB in listB)
            {
                if(nA == nB)
                {
                    if (minCommonPositive == -1 || nA < minCommonPositive)
                    minCommonPositive = nA; 
                }
            }
        }
    }
    return minCommonPositive;
}
