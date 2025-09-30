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
            Console.Write(" _ ");
        }
        Console.WriteLine("\nWhat's your letter choice: ");
        string charInput = Console.ReadLine();
        char value = char.Parse(charInput);

        if (randomWord.Contains(value))
        {
            for (int i = 0; i < randomWord.Length; i++)
            {
                if (randomWord[i] == value)
                {
                    Console.Write(randomWord[i]);
                }
                
            }
        }
        else
        {
            Console.Write("Guess again: ");
        }

    }
}