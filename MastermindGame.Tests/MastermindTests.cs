namespace MastermindGame.Tests
{
    public class MastermindTests
    {
        [Fact]
        public void PrintRulesToConsole_ShouldPrint()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); //captures output to the console

                var masterMindGame = new Mastermind();
                masterMindGame.PrintRulesToConsole();

                Assert.True(!string.IsNullOrEmpty(sw.ToString()));
            }
        }
    }
}