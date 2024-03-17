# Objective
Create a console application that is a simple version of the game "Mastermind" 

# Requirements
- The randomly generated answer should be four (4) digits in length, with each digit between the numbers 1 and 6.
- After the player enters a combination:

  A minus (-) sign should be printed for every digit that is correct but in the wrong position,
  
  A plus (+) sign should be printed for every digit that is both correct and in the correct position.

- Print all plus signs first, all minus signs second, and nothing for incorrect digits.
- The player has ten (10) attempts to guess the number correctly before receiving a message that they have lost.

# Assumptions
"Print all plus signs first, all minus signs second...":
- Application will print 2 rows of signs: 1st row has the (+) signs, and 2nd row is the (-) signs
- This requirement does not mean the application should print a single row with the (+) signs preceding the (-) signs, as this wouldn't clearly indicate the correlation between user input and the code

# Test Cases
A series of unit test cases have been created to test the basic functionality of the application.
