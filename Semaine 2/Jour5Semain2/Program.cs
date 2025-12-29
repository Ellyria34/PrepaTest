// Jour5 Semain2
string input = "Bonjour le monde";
//Exercice 1 
Console.WriteLine("Donner le nombre de mot contenu dans la chaine de caractères.");
int countWords = CountWords(input);
Console.WriteLine($"Il y a {countWords} mot dans cette chaîne de caractère.");


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
        Console.WriteLine($"{input[i]}");
        if((i == 0 && input[i]!= ' ') || (i != 0 && input[i] != ' ' && input[i-1] == ' '))
        {
            countWords++;
        }
    }
    return countWords ;
}