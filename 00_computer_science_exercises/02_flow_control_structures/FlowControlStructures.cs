using System;
class FlowControlStructures {
  static void Main() {
    // These blocks of code are used to control how the program executes.
    // Basically, these blocks of code allow for decisions to be made.

    // int age = 44;
    // double cheeseBurgers = 1.25D;
    // string favFlavor = "Butterscotch";
    // bool afraidSnakes = false;

    // // Can I vote?
    // if (age >= 18) // (age >= 18) is the CONDITIONAL STATEMENT
    // {
    //     Console.WriteLine("You can vote!\n");
    // } 
    // else if (age >= 16)// Check this NEXT if Line #13 is false.
    // {
    //   Console.WriteLine("You can't vote but you CAN register.\n");
    // }
    // else
    // {
    //     Console.WriteLine("You are not old enough to vote or register. Scrub.\n");
    // }

    // /*
    // You can have a single if statement by itself.
    // If you have an else you MUST also have an if.
    // You can have as many else if statements as needed.
    // FOR NOW, USE THE else CONDITION TO PRINT ERROR MESSAGES / LOGS
    // */

    // int age;
    // if (age >= 0)
    // {
    //   Console.WriteLine("Age data stored.\n");
    // }
    // else
    // {
    //   Console.WriteLine("No age value detected. Please review.\n");
    // }

    // // Switch Statements
    // int day = 1;
    // switch (day)
    // {
    //   case 1:
    //     Console.WriteLine("It's Monday.\n");
    //     break;
    //   case 2:
    //     Console.WriteLine("It's Tuesday.\n");
    //     break;
    //   case 3:
    //     Console.WriteLine("It's Wednesday.\n");
    //     break;
    //   // case 4 - 6
    //   case 7:
    //     Console.WriteLine("It's Sunday, go rest.\n");
    //     break;
    // }

    // REPEATING STEPS OVER, AND OVER, AND OVER AGAIN
    // LOOPS are used to repeat instructions multiple times.

    // while loops are "musical chairs" in computer science.
    // use while loops if you DO NOT know how many loops you need. 
    // the code will run as long as the condition is true.
    // while loop syntax:
    /*

    while (CONDTIONAL_EXPRESSION)
    {
        Code to loop goes here.
    }
    */

    // int z = 0;
    // while (z <= 100) // What do I replace CONDITIONAL_EXPRESSION with?
    // {
    //     Console.WriteLine(z); 
    //     z++;
    // }

    // int y = 100;
    // while (y >= 0)
    // {
    //   Console.WriteLine(y);
    //   y--;
    // }

    // for loops are like playing go fish.
    // you know how many cards in your hand.
    // used when you know how many loops you nees ahead of time.

    /*
    for (statement1; statement2; statement3)
    {
        Code to run each time through loop.
    }
    statement1 = code to run ONE TIME before the loop starts.
    statement2 = CONDITIONAL EXPRESSION to check EACH TIME before loop runs.
    statement3 = code to run AFTER each loop.

    Each 'trip' through the loop is called an ITERATION.
    */

    // Counting to 10 with for loops.
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine(i);
    }

    for (int i = 10; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
  }
}
