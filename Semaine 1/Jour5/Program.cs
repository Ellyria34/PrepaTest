Console.WriteLine("Jour 5");

List<int> listA = [1, 2, 3, 4];
List<int> listB = [3, 4, 5];

Console.WriteLine("Exercice 1 - Écrire une méthode qui compte combien de nombres de listA sont présents dans listB");
if(listA != null && listB != null && listA.Count > 0 && listB.Count > 0)
{
    int countCommon = CountCommon(listA, listB);
    if(countCommon > 0)
    {
        Console.WriteLine($"Il y a {countCommon} nombre(s) de la liste A présent dans la liste B.");
    }
    else
    {
        Console.WriteLine($"La liste A et la liste B n'ont aucun nombre en commun.");
    }
}
else
{
    Console.WriteLine($"Une des liste est vide.");    
}


//Methods
static int CountCommon(List<int> listA, List<int> listB)
{
    int result = 0;
    foreach(int n in listA)
    {
        int nA = n;
        foreach (int n2 in listB)
        {
            if(nA == n2)
            {
                result ++;
            }
        }
    }
    return result;
}