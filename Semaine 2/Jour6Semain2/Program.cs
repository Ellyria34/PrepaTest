// Jour6 Semaine2
string input = "Bonjour  le monde";

Console.WriteLine("La chaîne de caractères respecte-t-elle toute les conditions suivantes :");
Console.WriteLine("- elle contient au moins 2 mots,");
Console.WriteLine("- il n'y a aucun double espace,");
Console.WriteLine("- aucun des mots ne dépasse 10 caractère.");
Console.WriteLine("- il y a au moin une voyelle");

bool isValideSentence =  IsValideSentence(input);
if(isValideSentence)
{
    Console.WriteLine("Oui, la phrase respecte les conditions.");
}
else
{
    Console.WriteLine("Non, la phrase ne respecte pas les conditions.");
}

//Methods
static bool IsValideSentence(string input)
{
    if(input == null || input.Length <= 0)
    {
        return false;
    }

    int countWord = 0;
    int currentLengthWord = 0;
    for (int i = 0; i < input.Length-1; i++)
    {
        if (input [i] != ' ')
        {
            currentLengthWord++;
            
            if(input [i+1] == ' ')
            {
                if(currentLengthWord > 10)
                {
                    return false;
                }
            }
        }
        else
        {    
            if(currentLengthWord != 0)
            {
                countWord ++;
            }
            currentLengthWord = 0;
        }
    }
    if(currentLengthWord != 0)
    {
        countWord ++;
    }

    if(countWord < 2)
    {
        return false;
    }

    bool hasDoubleSpace = HasDoubleSpace(input);
    bool hasMinOneVoyelle = HasMinOneVoyelle(input);

    if (hasDoubleSpace || hasMinOneVoyelle == false)
    {
        return false;
    }
    return true;
}

static bool HasDoubleSpace(string input)
{
    if(input== null || input.Length <= 0)
    {
        return false;
    }

    for(int i = 0; i < input.Length-1; i++)
    {
        if(input [i] == ' ' && input [i+1] == ' ')
        {
            return true;
        }
    }
    return false;
}

static bool HasMinOneVoyelle(string input)
{
    foreach(char v in input)
    {
        if(v == 'a' || v == 'e' || v == 'i'  || v == 'o' || v == 'u' || v == 'y')
        {
            return true;
        }   
    }
    return false;
}