using System;
class livesProject {
    static void Main() {
        int lives = 3;
        Console.WriteLine("What is your score?\n");
        int score = Console.ReadLine();
        if (score < 10001)
        {
            Console.WriteLine("You have "+lives+ "life.\n");
           life--;
        }
        else if (score < 100000)
        {
            Console.WriteLine("You have "+lives+ "life.\n");
            life++;
        }
        else (score > 100000)
        {
            Console.WriteLine("You have "+lives+ "life.\n");
            life++;
            life++;
        }
    }
}
// I know that this code isn't working but I don't know what else to do or why my code is deciding to throw a fit over the { on line 18 but you aren't coming over to help me