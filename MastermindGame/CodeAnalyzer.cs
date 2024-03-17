using System.Text;

namespace MastermindGame
{
    public static class CodeAnalyzer
    {
        public static string GenerateCode(int maxLength)
        {
            var random = new Random();
            var code = new StringBuilder(maxLength);

            for (int i = 0; i < maxLength; i++)
            {
                code.Append(random.Next(1, 7)); //generates a number between 1 and 6 (inclusive)
            }

            return code.ToString();
        }

        /// <summary>
        /// Parses the user input and provides feedback to user.
        /// As per requirements, all (+) signs are printed first, followed by all of the (-) signs
        /// </summary>
        /// <param name="code">The master code (hidden from user)</param>
        /// <param name="guess">User input to compare against the code</param>
        /// <returns> True, if user has correctly guessed the full code combination. False, otherwise.
        /// </returns>
        public static bool ParseGuess(string code, string guess)
        {
            if (code.Equals(guess))
            {
                return true;
            }

            //As per requirements, user must be shown all (+) signs first, followed by the (-) signs
            for (int i = 0; i < guess.Length; i++)
            {
                if (code[i].Equals(guess[i]))
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < guess.Length; i++)
            {
                if (!code[i].Equals(guess[i]) && code.Contains(guess[i]))
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();

            return false;
        }
    }
}
