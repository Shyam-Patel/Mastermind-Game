namespace MastermindGame
{
    public class Mastermind
    {
        private const int MaxCodeLength = 4;
        private const int MaxUserAttempts = 10;

        public Mastermind() { }

        public void Play()
        {
            string masterCode = CodeAnalyzer.GenerateCode(MaxCodeLength);

            for (int i = 0; i < (MaxUserAttempts - 1); i++)
            {
                Console.WriteLine($"Enter your guess (attempt # {(i + 1)}): ");
                var userInput = Console.ReadLine();

                if(string.IsNullOrEmpty(userInput) || userInput.Length != 4 || !userInput.All(char.IsDigit))
                {
                    Console.WriteLine("You have entered an invalid input!");
                    continue;
                }

                var correctGuess = CodeAnalyzer.ParseGuess(masterCode, userInput);
                if (correctGuess)
                {
                    Console.WriteLine("Success! Well done, master code breaker!");
                    return;
                }
            }

            Console.WriteLine($"Sorry, you have exhausted your attempts. The code was [{masterCode}]");
        }

        public void PrintRulesToConsole()
        {
            string rules = "OBJECTIVE: There is a secret 4-digit code you must break! Each digit in the code is between 1 and 6 (inclusive)." +
                "\n You will have 10 attempts to break the code." +
                "\n\nRULES: " +
                "\n 1) Type a guess (4-digit code) and press 'Enter'" +
                "\n 2) After each guess:" +
                "\n\t - a minus (-) sign will be printed for every digit that is correct BUT in the wrong position" +
                "\n\t - a plus (+) sign will be printed for every digit that is both correct AND in the correct position" +
                "\n\t - an empty space ' ' will be shown for a digit that is not in the code combination" +
                "\n All (+) signs (correct digits in correct positions) will be shown first, followed by (-) signs (correct digits in wrong position)" +
                "\nGood luck!\n";

            Console.WriteLine(rules);
        }
    }
}
