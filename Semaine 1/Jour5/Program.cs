using System.ComponentModel;

Console.WriteLine("Jour 5");

List<int> listA = [1, 2, 3, 4];
List<int> listB = [3, 4, 5];

if(listA != null && listB != null && listA.Count > 0 && listB.Count > 0)
{
    //Exercice 1
    Console.WriteLine("Exercice 1 - Écrire une méthode qui compte combien de nombres de listA sont présents dans listB");
    int countCommon = CountCommon(listA, listB);
    if(countCommon > 0)
    {
        Console.WriteLine($"Il y a {countCommon} nombre(s) de la liste A présent dans la liste B.");
    }
    else
    {
        Console.WriteLine($"La liste A et la liste B n'ont aucun nombre en commun.");
    }
    //Exercice 2
    Console.WriteLine("Exercice 2 - Est ce que tous les nombres de la liste A sont présent dans la liste B?");
    bool allInSecondList = AllInSecondList(listA, listB);
    if(allInSecondList)
    {
        Console.WriteLine("Oui tous les nombres de la liste A se trouve dans la liste B.");
    }
    else
    {
        Console.WriteLine("Non, tous les nombres de la liste A ne se trouve pas dans la liste B.");
    }

    //Test Final
    Console.WriteLine("Test final - Retourne la somme des nombres STRICTEMENT positifs présents dans les DEUX listes.");
    int sumCommonPositive = SumCommonPositiv(listA, listB);
    Console.WriteLine($"La somme des nombres strictement positifs et présents dans les deux listes est égale à : {sumCommonPositive}.");
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

static bool AllInSecondList(List<int> listA, List<int> listB)
{
    foreach(int nA in listA)
    {
        bool found = false;

        foreach(int nB in listB)
        {
            if(nA == nB)
            {
                found = true;
                break;
            }
        }
        if(!found)
        {
            return false;
        }
    }
    return true;
}

static int SumCommonPositiv(List<int> listA, List<int> listB)
{
    int sum = 0;

    foreach(int nA in listA)
    {
        if(nA > 0)
        {
            foreach (int nB in listB)
            {
                if(nA == nB)
                {
                    sum = sum + nA;
                    break;
                }
            }
        }
    }
    return sum;
}