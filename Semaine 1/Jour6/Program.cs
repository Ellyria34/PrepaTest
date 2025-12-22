//Jour 6

//Partie A : Test révision
using System.ComponentModel;

Console.WriteLine("Partie A - Test Révision : Écrire une méthode qui retourne le plus petit nombre STRICTEMENT positif commun aux deux listes.");
List<int> list = [5, -2, 0, 3, 0, -1]; 
List<int> listA = [1, 3, 5];
List<int> listB = [2, 3, 4, 5];
// List<int> listA = [-1, -2];
// List<int> listB = [1, 2];
if(listA != null && listB != null && listA.Count > 0 && listB.Count > 0)
{
    int minCommonPositive = MinCommonPositive(listA, listB);
    Console.WriteLine($"{minCommonPositive} est plus petit nombre positif contenu dans la listA et listB.");    
}
else
{
    Console.WriteLine("Une des deux listes est vide");
}

//Partie B : Nouveau pattern
Console.WriteLine("Partie B - Nouveau pattern : Écrire une méthode qui compte séparément :le nombre de nombres strictement positifs, le nombre de nombres strictement négatifs et le nombre de zéros");
if(list != null && list.Count > 0)
{
    int positives, negatives, zeros;
    CountBySign(list, out positives, out negatives, out zeros);

    Console.WriteLine($"Il y a {positives} nombre positifs, {negatives} nombre négatifs et {zeros} zero dans la list.");
}
else
{
    Console.WriteLine("Une des deux listes est vide");
}

//Methodes
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

static void CountBySign(List<int> list, out int positives, out int negatives, out int zeros)
{
    positives = 0;
    negatives = 0;
    zeros = 0;

    foreach(int n in list)
    {
        if (n < 0)
        {
            negatives ++;
        }
        else if (n > 0)
        {
            positives ++;
        }
        else
        {
            zeros ++;
        }
    }
}
