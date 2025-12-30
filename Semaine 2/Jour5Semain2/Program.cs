// Jour5 Semain2
string input = "Bonjour le monde";
//Exercice 1 
Console.WriteLine("Donner le nombre de mot contenu dans la chaine de caractères.");
int countWords = CountWords(input);
Console.WriteLine($"Il y a {countWords} mot dans cette chaîne de caractère.");

//Exercice 2 
Console.WriteLine("La chaîne de caractères contient-elle au moins deux espaces consécutifs.");
bool hasDoubleSpace = HasDoubleSpace(input);
if(hasDoubleSpace)
{
    Console.WriteLine($"Oui, Cette chaîne de caractère contient bien un double espaces.");    
}
else
{
    Console.WriteLine($"Non, Cette chaîne de caractère ne contient pas de double espaces.");        
}

//Exercice 3 
Console.WriteLine("Donner la taille du mot le plus long de la chaîne de caractères.");
int longestWord = LongestWord(input);
Console.WriteLine($"Le mot le plus long est contient {longestWord} caractères.");



//Methods
static int CountWords(string input)
{
    if(input == null || input.Length <= 0)
    {
        return 0;
    }
    
    int countWords = 0;

    for(int i = 0 ; i < input.Length; i++)
    {
        if((i == 0 && input[i]!= ' ') || (i != 0 && input[i] != ' ' && input[i-1] == ' '))
        {
            countWords++;
        }
    }
    return countWords ;
}

static bool HasDoubleSpace(string input)
{
    if(input == null || input.Length <= 0)
    {
        return false;
    }

    for(int i = 0 ; i < input.Length-1; i++)
    {
        if((input[i] == ' ') && input[i+1] == ' ')
        {
            return true;
        }
    }
    return false;  
}

static int LongestWord(string input)
{
    int longestWord = 0;
    int currentLengthWord = 0;
    if (input == null || input.Length <= 0)
    {
        return 0;
    }

    foreach(char v in input)
    {
        if(v != ' ')
        {
            currentLengthWord ++;
            if(currentLengthWord > longestWord)
        {
            longestWord = currentLengthWord;
        }
        }
        else
        {
            currentLengthWord = 0;
        }
    }
    return longestWord;
}