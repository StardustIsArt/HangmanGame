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
        }

        bool wordGuessed = false;
        while (!wordGuessed)
        {
            Console.WriteLine(new string(displayLetters));
            Console.WriteLine("What's your letter choice: ");
            
            string charInput = Console.ReadLine();
            char guess = char.Parse(charInput);
            
            if (!hiddenWord.Contains(guess))
            {
                Console.WriteLine("Try again");
            }
            
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                if (hiddenWord[i] == guess)
                { 
                    displayLetters[i] = guess;
                }
            }
           
            
        }
        if (wordGuessed)
        { 
            Console.WriteLine("You WON! Thanks for playing: " + randomWord);
        }
        else
        { 
            Console.WriteLine("You Lost! Thanks for playing: " + randomWord);
        } 
    }
}


// needed is a counter for how many tries they get and which number of tries they are on. 
