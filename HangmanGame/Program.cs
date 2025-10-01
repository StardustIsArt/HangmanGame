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
        char[] hiddenWord = randomWord.ToCharArray();
        char[] displayLetters = new char[randomWord.Length];
       
        for (int i = 0; i < randomWord.Length; i++)
        {
            displayLetters[i] = '_';
            Console.Write(displayLetters[i]);
        }
        Console.WriteLine("\nWhat's your letter choice: ");
        string charInput = Console.ReadLine();
        char value = char.Parse(charInput);
        
       /* for (int i = 0; i < hiddenWord.Length; i++)
        {
            if (displayLetters[i] == value)
            { 
                Console.Write(displayLetters[i]);
            }
            else
            {
                Console.Write("Guess again: "); 
                charInput = Console.ReadLine();
            }
        }*/
       while (displayLetters[value] != value)
       {
           Console.Write("\nGuess again: ");
           if (value == hiddenWord.Length)
           {
               for (int i = 0; i < hiddenWord.Length; i++)
               {
                   if (hiddenWord[i] == value)
                   {
                       displayLetters[i] = value;
                   }
                   else
                   {
                       Console.Write(value);
                   }
               } 
           }
       }
    }
}

// needed is a counter for how many tries they get and which number of tries they are on. 
