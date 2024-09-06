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
      Console.WriteLine("Secret Number: " + secretNumber);
      Console.WriteLine("Please guess an integer between 0 and 20.\n");
      guess = Convert.ToInt32(Console.ReadLine()); 
      Console.WriteLine("Guess" + guess);

      numGuess++;
      if (guess < secretNumber)
      {
        Console.WriteLine("your guess is too low.\n");
      }
      else if (guess > secretNumber)
      {
        Console.WriteLine("your guess is too high.\n");
      }
      else
      {
        Console.WriteLine("You guessed correctly!\n");
        break; // Keyword to immediately exit a loop.
      }

      if (numGuess >= maxGuess)
      {
        Console.WriteLine("You have lost the game.\nDisappointing.\n");
      }

    }
      
      





  }
}