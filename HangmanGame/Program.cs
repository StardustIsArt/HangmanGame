using Microsoft.VisualBasic.CompilerServices;

namespace HangmanGame;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's play the hangman game!");
        
        List<string> possibleWords = new List<string>(){"galaxy", "asgard", "space", "flare", "quantum"};
        const string MISSING_VALUE = "_";
        Random rand = new Random();
        string randomWord = possibleWords[rand.Next(0, possibleWords.Count)];
        Console.WriteLine(randomWord);
        Console.WriteLine("What's your letter choice: ");
        string charInput = Console.ReadLine();

        char value = char.Parse(charInput);
        
        Console.WriteLine(randomWord.IndexOf(value));
            
        
       /* if (value != char.Parse(randomWord))
        {
            Console.WriteLine(missingValue);
        }*/
       
    }
}