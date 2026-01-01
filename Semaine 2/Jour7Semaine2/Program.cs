// Jour 7 Semaine 2
using System.Runtime.InteropServices;

Console.WriteLine("Jour 7 Semain 2");

string sentence = "La phrase contient au moins un mot de plus de 5 caractères et ne commence et ne se termine pas par un espace.";

Console.WriteLine("Partie A - Ecrire une méthode pour vérifier que la phrase contient au moins un mot de plus de 5 caractères et qu'elle ne commence et ne se termine pas par un espace.");
bool isValidForA = IsValidForA(sentence); 
if(isValidForA)
{    
    Console.WriteLine("Oui, la phrase est valide.");
}
else 
{
    Console.WriteLine("Non, la phrase n'est pas valide.");
}

Console.WriteLine("Partie B - Ecrire une méthode pour vérifier que la phrase contient au moins 3 mots, aucun moy vide \"\", aucun mot ne commencant ou ne se terminant par un espace, avec au moins un mot ayant plus de 5 caractères et aucun mot contenant 2 lettres indentiques consécutives.");
List<string> words = sentence.Split(" ");
bool isValidForB = IsValidForB(words); 
if(isValidForB)
{    
    Console.WriteLine("Oui, la phrase est valide.");
}
else 
{
    Console.WriteLine("Non, la phrase n'est pas valide.");
}

//Methods
static bool IsValidForA(string sentence)
{
    int currentWordLength = 0;
    if(string.IsNullOrEmpty(sentence))
    {
        return false;
    }

    if(sentence[0] == ' ' || sentence[sentence.Length-1] == ' ')
    {
        return false;
    }

    for(int i = 0; i < sentence.Length; i++)
    {
        if(sentence[i] != ' ')
        {
            currentWordLength ++;
            if(currentWordLength > 5)
            {
                return true;
            }
        }
        else
        {
            currentWordLength = 0;
        }
    }
    return false;
}

static bool IsValidForB(List<string> words)
{
    int wordsCount = words.Count;
    bool isLongerThan5Char = false;
    foreach(string word in words)
    {
        if(word == "")
        {
            return false;
        }
        if(word.Length>5)
        {
            isLongerThan5Char = true;
        }
        for(int i = 0; i < word.Length-1; i++)
        {
            if(word[i] == word[i+1])
            {
                return false;
            }
        }
    }
    if(wordsCount >= 3 && isLongerThan5Char)
    {
        return true;
    }
    else 
    {
        return false;
    }
}