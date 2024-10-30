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
  int[] testScore = {0, 25, 15, 75, 99};
  double[] GPA = {0.27D, 1.99D, 4.02D, 0.0D, 3.25D};

  // Print Array Contents -- All Elements on Single Line
  Console.WriteLine("The elements of each array are:\n");
  Console.WriteLine("breakFastFoods: \n" + String.Join(", ", breakfastFoods));
  Console.WriteLine(); // Print an empty line to the screen.

  // Print Array Elements on Separate Lines
  Console.WriteLine("The elements of each array are:\n");
  Console.WriteLine("testScore: \n" + String.Join("\n", testScore));
  Console.WriteLine(); // Print an empty line to the screen.

  // How long is my array? DETERMINING ARRAY LENGTH
  Console.WriteLine("The length of the breakFastFoods array is: " + breakfastFoods.Length);
  // .Length is known as a PROPERTY of the array.

  // Accessing Elements in the array with the index.
  Console.WriteLine("The first element in breakFastFoods is: " + breakfastFoods[0]);
  Console.WriteLine("The second element in testScores is: " + testScore[1]);
  Console.WriteLine("The third element in GPA is: " + GPA[2]);


    
  } // DO NOT DELETE EVER, 3 SPACES INDENTED FROM LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN