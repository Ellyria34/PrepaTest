// Semaine 3

using System.Transactions;

string input = "Bonjour le monde.";
//string input = "Bonjour le monde. Est ce que le monde va bien?";

List<string> words = input.Split(" ").ToList();
//string[] words = ["a", "", "b"];
//string[] words = ["un", "deux", "trois", "quatre"];

//Partie A
Console.WriteLine("Partie A - Écrire une méthode qui retourne true si une liste de chaînes contient au moins un mot vide (\"\").");

static bool ContainsEmptyString(List<string> words)
{
    if(words == null)
    {
        return false;
    }

    foreach(string word in words)
    {
        if (word == "")
        {
            return true;
        }
    }
    return false;
}

//Partie B
Console.WriteLine("Partie B - Écrire une méthode qui retourne true si la liste contient au moins deux mots identiques sans tenir compte de la casse.");

static bool ContainsDuplicateIgnoringCase(List<string> words)
{
    string currentWord = "";
    if(words == null)
    {
        return false;
    }

    for(int i = 0; i < words.Count; i++)
    {
        currentWord = words[i].ToLower();
        for(int j = i+1; j < words.Count; j++ )
        {
            if(currentWord == words[j].ToLower())
            {
                return true;
            }
        }
    }
    return false;
}

//Partie C
Console.WriteLine("Partie C - Écrire une méthode qui retourne true si toutes les conditions suivantes sont respectées :");
Console.WriteLine("- La liste contient au moins 3 mots");
Console.WriteLine("- Aucun mot n’est null");
Console.WriteLine("- Aucun mot n’est vide");
Console.WriteLine("Tous les mots sont uniques, sans tenir compte de la casse");
Console.WriteLine("Il existe au moins un mot de longueur ≥ 6");

static bool IsValidWordCollection(List<string> words)
{
    
    if(words == null)
    {
        return false;
    }
    
    List<string> normalizeWords = new List<string>();
    normalizeWords = NormalizeStringList(words);
    
    if(normalizeWords.Count < 3)
    {
        return false;
    }

    int maxLenghtWord = 0;

    foreach(string normalizeWord in normalizeWords)
    {
        if (normalizeWord == null || normalizeWord ==  "")
        {
            return false;
        }
        else
        {
            int currentWordLenght = normalizeWord.Length;
            if(currentWordLenght > maxLenghtWord)
            {
                maxLenghtWord = currentWordLenght;
            }
        }
    }

    if(ContainsDuplicateIgnoringCase(normalizeWords) || maxLenghtWord < 6)
    {
        return false;
    }
    
    return true;
}

static List<string> NormalizeStringList(List<string> words)
{
    List<string> normalizeStringList = new List<string>();
    if(words == null)
    {
        return normalizeStringList;
    }
    
    foreach(string word in words)
    {
        if(word == null)
        {
            normalizeStringList.Add("");
            continue;
        }

        string normalizedWord = "";
        
        foreach(char c in word.ToLower().Trim())
        {
            if(char.IsLetterOrDigit(c))
            {
                normalizedWord += c;   
            }
        }
        normalizeStringList.Add(normalizedWord);
    }
    return normalizeStringList;
}

