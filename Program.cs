namespace MastermindGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mastermind!");

            var game = new Mastermind();
            game.PrintRulesToConsole();
            game.Play();
        }
    }
}