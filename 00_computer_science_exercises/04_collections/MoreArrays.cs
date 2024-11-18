using System;
using System.Linq;
using System.Collections;

class MoreArrays {
  static void Main() { // DO NOT DELETE!

  string[] colors = { "Garnet", "Gold", "Purple", "Teal", "Fuschia"};
  // LOOPING THROUGH ARRAYS -- The old way.
  for (int i = 0; i < colors.Length; i++)
  {
      Console.WriteLine(colors[i]);
  }

  // Looping through arrays -- the new hotness.
  foreach (string i in colors)
  {
      Console.WriteLine(i);
  }
    
    // Looping through Array Practice
  int[] numbers = {-10, 25, -345, 45, 9999, 1, 0, 68, 538, -99999};
  foreach (int i in numbers)
  {
      Console.WriteLine(i);
      if (i % 2 == 0)
      {
        Console.WriteLine("Even\n");
      }
      else
      {
        Console.WriteLine("Odd\n");
      }
  }
  


  } // DO NOT DELETE EVER, 3 SPACES INDENTED FROM LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN