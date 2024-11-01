// Collections Example, Lily King, v0.0
using System;
using System.Linq;
using System.Collections;


class Collections {
  static void Main() { // DO NOT DELETE!

  /*
  In C# an collection is known as an ARRAY.
  -- EACH ITEM IN THE ARRAY IS AN ELEMENT
  -- NUMBER OF ELEMENTS IN THE ARRAY CANNOT BE CHANGED.
  -- CONTENTS OF EACH ELEMENT CAN CHANGE. 
  -- ARRAYS ARE ORDERED, MEANING EACH ITEM HAS A FIXED POSITION.
  -- POSITION OF THE ELEMENT IS THE INDEX
  -- FIRST ELEMENT INDEX IS 0. 
  */

  // DECLARING AND DEFINING AN ARRAY
  string[] breakfastFoods = {"Bacon", "Eggs", "Cold Pizza", "Capn' Crunch", "Gator Tail"};
  int[] testScores = {0, 25, 15, 75, 99};
  double[] GPA = {0.27D, 1.99D, 4.02D, 0.0D, 3.25D};

  // Print Array Contents -- All Elements on Single Line
  // Console.WriteLine("The elements of each array are:\n");
  // Console.WriteLine("breakfastFoods: \n" + String.Join(", ", breakfastFoods));
  // Console.WriteLine(); // Print an empty line to the screen.
  /*
  // Print Array Elements on Separate Lines
  Console.WriteLine("The elements of each array are:\n");
  Console.WriteLine("testScores: \n" + String.Join("\n", testScores));
  Console.WriteLine(); // Print an empty line to the screen.

  // How long is my array? DETERMINING ARRAY LENGTH
  Console.WriteLine("The length of the breakfastFoods array is: " + breakfastFoods.Length);
  // .Length is known as a PROPERTY of the array.

  // Accessing Elements in the array with the index.
  Console.WriteLine("The first element in breakfastFoods is: " + breakfastFoods[0]);
  Console.WriteLine("The second element in testScoress is: " + testScores[1]);
  Console.WriteLine("The third element in GPA is: " + GPA[2]);
  
  // Shortcut to Access Last Item in an Array
  Console.WriteLine("The last element of breakfastFoods is: " + breakfastFoods[breakfastFoods.Length - 1]);
  Console.WriteLine("The last element of testScores is: " + testScores[testScores.Length - 1]);

  // CHANGING ELEMENTS IN THE ARRAY
  breakfastFoods[2] = "Food";
  testScores[0] = -4;
  GPA[1] = 4.4D;
  Console.WriteLine("The elements of each array are:\n");
  Console.WriteLine("breakfastFoods: \n" + String.Join(", ", breakfastFoods));
  Console.WriteLine(); // Print an empty line to the screen.
  */

  // COMMON ERRORS WITH ARRAYS
  // Console.WriteLine(breakfastFoods[99]); // Index Out of Bounds -- Accessing index that does not exist in the array.
   
  // testScores[0] = "99"; // Error Message "Cannot implicitly convert dataType to dataType"
  // Trying to put incorrect data tyoe into the array.
    
  } // DO NOT DELETE EVER, 3 SPACES INDENTED FROM LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN