namespace HangmanGame;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's play the hangman game!");
        
        List<string> possibleWords = new List<string>(){"galaxy", "asgard", "space", "flare"};

        Random Word = new Random();
        string randomWord = possibleWords[Word.Next(0, possibleWords.Count)];
        string charInput = Console.WriteLine("What's your letter choice: ");
        
        if (charInput == char.IsLetter(randomWord[0]))
        {
        // how to not be redundant with looking for letters in each character spot?
            Console.WriteLine(charInput);
        }   
        
            
    }
}