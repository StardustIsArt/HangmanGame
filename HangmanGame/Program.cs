namespace HangmanGame;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's play the hangman game!");
        
        List<string> possibleWords = new List<string>(){"galaxy", "asgard", "space", "flare"};

        Random Word = new Random();
        string randomWord = possibleWords[Word.Next(0, possibleWords.Count)];
     
        
    }
}