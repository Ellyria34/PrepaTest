// Jour 4 Semaine 2
string input = "abc1def";
//Exercice 1
Console.WriteLine("Exercice 1 - Combien de voyelle sont présentes dans la chaîne de caractères.");
int countVowels = CountVowels(input);
Console.WriteLine($"Il y a {countVowels} dans cette chaîne de caractères.");

//Exercice 2
Console.WriteLine("Exercice 2 - Est ce que la chaîne de caractères contient au moins un chiffre.");
bool containsDigit = ContainsDigit(input);
if(containsDigit)
{
    Console.WriteLine($"Oui il y a au moins un nombre dans cette chaîne de caractères.");    
}
else
{
    Console.WriteLine($"Non il n'y a pas de nombre dans cette chaîne de caractères.");    
}


//Methods
static int CountVowels(string input)
{
    int countVowels = 0;

    if(string.IsNullOrEmpty(input))
    {
        return 0;
    }

    foreach(char v in input.ToLower())
    {
        if(v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u' || v == 'y')
        {
            countVowels ++;
        }
    }
    return countVowels;    
}

static bool ContainsDigit(string input)
{
        if(string.IsNullOrEmpty(input))
    {
        return false;
    }

    foreach(char v in input)
    {
        if(v == '0' || v == '1' || v == '2' || v == '3' || v == '4' || v == '5' || v == '6' || v == '7' || v == '8' || v == '9')
        {
            return true;
        }
    }
    return false;
}
