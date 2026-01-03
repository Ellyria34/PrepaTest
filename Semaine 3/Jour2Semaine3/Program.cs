// Jour 2 Semaine 3


Console.WriteLine("Partie A - Écrire une méthode qui retourne true si une liste de chaînes contient au moins un doublon, sans tenir compte de la casse (!!! pas de double boucle for).");

static bool ContainsDuplicateIgnoringCase(List<string> words)
{
    if(words == null)
    {
        return false;
    }

    List<string> normalisedWords = NormalisedWords(words);

    HashSet<string> seenwords = new HashSet<string>();

    foreach(string normalisedWord in normalisedWords)
    {
        if (seenwords.Contains(normalisedWord))
        {
            return true;
        }
        seenwords.Add(normalisedWord);
    }
    return false;
}

Console.WriteLine("Partie B - Écrire une méthode qui compte combien de fois chaque mot apparaît dans une phrase (insensible à la casse).");
// A faire


Console.WriteLine("Partie C - Écrire une méthode qui retourne true si toutes les conditions suivantes sont respectées :");
Console.WriteLine("- La liste contient au moins 4 mots");
Console.WriteLine("- Aucun mot n’est null ou vide");
Console.WriteLine("- Tous les mots sont uniques (sans tenir compte de la casse)");
Console.WriteLine("- Il existe au moins un mot apparaissant au moins 2 fois");
Console.WriteLine("- Aucun mot ne contient de caractère non alphabétique)");
// A faire


// Common Methods
static List<string> NormalisedWords(List<string> words)
{
    List<string> normalizedWords = new List<String>();
    if(words == null)
    {
        return normalizedWords;
    }

    foreach(string word in words)
    {
        if(word == null)
        {
            normalizedWords.Add("");
            continue;
        }

        string normalisedWord = "";

        //Put in lowercase and remove spaces at the beginning and end
        foreach(char c in word.ToLower().Trim())
        {
            //Remove punctuation
            if(char.IsLetterOrDigit(c))
            {
                normalisedWord += c;
            }
        }
        normalizedWords.Add(normalisedWord);
    }
    return normalizedWords;
}