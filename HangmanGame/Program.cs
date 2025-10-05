using Microsoft.VisualBasic.CompilerServices;

namespace HangmanGame;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's play the hangman game!");
        List<string> possibleWords = new List<string>() { "galaxy", "asgard", "space", "flare", "quantum" };
        Random rand = new Random();
        string randomWord = possibleWords[rand.Next(0, possibleWords.Count)];
        char[] hiddenWord = randomWord.ToCharArray();
        char[] displayLetters = new char[randomWord.Length];

        List<char> guessedLetters = new List<char>();
        
        for (int i = 0; i < randomWord.Length; i++)
        {
            displayLetters[i] = '_';
        }

        int lives = 5;
        bool wordGuessed = false;
        while (!wordGuessed && lives > 0)
        {
            Console.WriteLine(new string(displayLetters));
            Console.WriteLine("What's your letter choice: ");
            Console.WriteLine($"You have {lives} guesses remaining.");
            string charInput = Console.ReadLine();
            char guess = char.Parse(charInput);
            

            if (!hiddenWord.Contains(guess))
            {
                lives--;
                if (guessedLetters.Contains(guess))
                {
                    Console.WriteLine("You have already guessed this letter.");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine("Try again");
                if (lives == 0 && !wordGuessed)
                {
                    Console.WriteLine("Game over! You lost!");
                }
                
                guessedLetters.Add(guess);
            }

            for (int i = 0; i < hiddenWord.Length; i++)
            {
                if (hiddenWord[i] == guess)
                {
                    displayLetters[i] = guess;
                }
            }

            if (new string(displayLetters) == randomWord)
            {
                wordGuessed = true;
            }
           
        }

        if (wordGuessed)
        {
            Console.WriteLine("You WON! Thanks for playing: " + randomWord);
        }
    }
}


// needed is a counter for how many tries they get and which number of tries they are on. 
