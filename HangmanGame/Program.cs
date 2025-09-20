using Microsoft.VisualBasic.CompilerServices;

namespace HangmanGame;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's play the hangman game!");
        
        List<string> possibleWords = new List<string>(){"galaxy", "asgard", "space", "flare", "quantum"};

        Random rand = new Random();
        string randomWord = possibleWords[rand.Next(0, possibleWords.Count)];
   
        Console.WriteLine("What's your letter choice: ");
        string charInput = Console.ReadLine();
   
    }
}