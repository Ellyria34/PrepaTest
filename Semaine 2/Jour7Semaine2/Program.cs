// Jour 7 Semaine 2
Console.WriteLine("Jour 7 Semain 2");

string sentence = "La phrase contient au moins un mot de plus de 5 caractères et ne commence et ne se termine pas par un espace.";

Console.WriteLine("Ecrire une méthode pour vérifier que la phrase conyient au moins un mot de plus de 5 caractères et qu'elle ne commence et ne se termine pas par un espace.");
bool isValide = IsValide(sentence); 
if(isValide)
{    
    Console.WriteLine("Oui, la phrase est valise.");
}
else 
{
    Console.WriteLine("Non, la phrase n'est pas valise.");
}

//Methods
static bool IsValide(string sentence)
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