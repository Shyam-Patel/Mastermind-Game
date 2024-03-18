using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindGame.Tests
{
    public class CodeAnalyzerTests
    {
        [Fact]
        public void GenerateCode_GeneratesCorrectLength()
        {
            int expectedLength = 4;

            var code = CodeAnalyzer.GenerateCode(expectedLength);
            Assert.Equal(expectedLength, code.Length);
        }

        [Fact]
        public void GenerateCode_GeneratesOnlyDigits()
        {
            var code = CodeAnalyzer.GenerateCode(4);
            Assert.True(int.TryParse(code, out _));
        }

        [Fact]
        public void ParseGuess_ReturnsTrueForCorrectGuess()
        {
            var code = "4325";
            Assert.True(CodeAnalyzer.ParseGuess(code, "4325"));
        }

        [Fact]
        public void ParseGuess_ReturnsFalseForIncorrectGuess()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var code = "4325";
                Assert.False(CodeAnalyzer.ParseGuess(code, "2124"));
            }
        }
    }
}
