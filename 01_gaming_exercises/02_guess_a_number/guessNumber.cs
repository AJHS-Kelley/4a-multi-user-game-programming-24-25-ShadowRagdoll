using System;
class GuessNumber {
  static void Main() {
    int numGuess = 0;
    int maxGuess = 4; 
    int guess;

    // Generate the secret number here.
    Random rnd = new Random(); // Create an object named 'rnd' that is a copy of the Random() class.
    int secretNumber = rnd.Next(21); // Generate from 0 to 20
    // Console.WriteLine(secretNumber); // COMMENT OUT AFTER TESTING
    // int secretNumber = rnd.Next(25, 1000); // Generate from 25 to 999

    while (numGuess < maxGuess)
    {
      Console.WriteLine("Please guess an integer between 0 and 20.\n");
      guess = Convert.ToInt32(Console.ReadLine()); 
      Console.WriteLine(guess);
      numGuess++;
    }
      // Allow the user to guess the number.
      // Compare the guess to the secret number.
      // If match, print win, if > or <, give a hint.
      // +1 to numGuess
      // Check if numGuess > maxGuesses.
      // If true, print a "lose game" message, if false guess again.





  }
}