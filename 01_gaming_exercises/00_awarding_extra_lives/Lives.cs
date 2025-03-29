using System;
class livesProject {
    static void Main() {
        int lives = 3;
        Console.WriteLine("What is your score?\n");
        int score = Convert.ToInt32(Console.ReadLine());
        if (score < 10001)
        {
            Console.WriteLine("You have "+lives+ "life.\n");
           lives--;
        }
        else if (score < 100000)
        {
            Console.WriteLine("You have "+lives+ "life.\n");
            lives++;
        }
        else
        {
            Console.WriteLine("You have "+lives+ "life.\n");
            lives++;
            lives++;
        }
    }
}