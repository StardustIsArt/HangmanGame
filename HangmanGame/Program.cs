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
        foreach (char c in randomWord)
        {
            Console.Write("_ ");
        }
        Console.WriteLine("\nWhat's your letter choice: ");
        
        string charInput = Console.ReadLine();
        char value = char.Parse(charInput);

        if (randomWord.Contains(value))
        {
            foreach (char c in randomWord)
            {
                if (Char.IsLetter(c))
                    Console.Write(randomWord.IndexOf(value));
                else
                {
                    Console.Write("_ ");
                }
            }
        }

    }
}