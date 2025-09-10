namespace HangmanGame;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's play the hangman game!");
        
        List<string> possibleWords = new List<string>(){"galaxy", "asgard", "space", "flare"};

        Random Word = new Random();
        string randomWord = possibleWords[Word.Next(0, possibleWords.Count)];
        
        Console.WriteLine("What's your letter choice: ");
        string charInput = Console.ReadLine();
        
        //place randomWord into a function (or is that how one would in JS) that cycles through the character array of that
        //particular randomWord. if yes - print letter in correct position and ask for another letter. if no state "try again".
        //print out the current state of the game.
        
        //
        
        
            
    }
}