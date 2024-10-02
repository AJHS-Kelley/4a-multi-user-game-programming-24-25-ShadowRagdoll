using System;
class RPS {
  static void Main() {
    int playerScore;
    int cpuScore;
    int playerChoice;
    int cpuChoice;
    int numDraws = 0;


    Console.WriteLine("Rock beats Scissors, Scissors beats Paper, and Paper beats Rock. The winner scores a point. If each player picks the same no points are awarded. The first player to five points wins.\n");
    playerScore = 0;
    cpuScore = 0;
    // TESTING GAME LOOP
    int loopCount = 0;
    int loopReqs = 0; // Req / Reqs is universal abbrv. for REQUEST / REQUESTS 
    Console.WriteLine("How many loops do you need?\nType an INTEGER and press ENTER.\n");
    loopReqs = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    while (loopCount < loopReqs)
    {
        cpuChoice = rnd.Next(3);
        playerChoice = rnd.Next(3);
        //Console.WriteLine(cpuChoice);
        if (playerChoice == 1 && cpuChoice == 0)
        {
            Console.WriteLine("Paper beats rock.\n");
            Console.WriteLine("You won a point.\n");
            playerScore++;
            //playerScore = playerScore + 1;
        }
        else if (playerChoice == 2 && cpuChoice == 0)
        {
            Console.WriteLine("Scissors loses to rock.\n");
            Console.WriteLine("The CPU won a point.\n");
            cpuScore++;
            //cpuScore = cpuScore + 1;
        }
        else if (playerChoice == 0 && cpuChoice == 1)
        {
            Console.WriteLine("Rock loses to paper.\n");
            Console.WriteLine("The CPU won a point.\n");
            cpuScore++;
            //cpuScore = cpuScore + 1;
        }
        else if (playerChoice == 2 && cpuChoice == 1)
        {
            Console.WriteLine("Scissors beats paper.\n");
            Console.WriteLine("You won a point.\n");
            playerScore++;
            //playerScore = playerScore + 1;
        }
        else if (playerChoice == 0 && cpuChoice == 2)
        {
            Console.WriteLine("Rock beats scissors.\n");
            Console.WriteLine("You won a point.\n");
            playerScore++;
            //playerScore = playerScore + 1;
        }
        else if (playerChoice == 1 && cpuChoice == 2)
        {
            Console.WriteLine("Paper loses to scissors.\n");
            Console.WriteLine("The CPU won a point.\n");
            cpuScore++;
            //cpuScore = cpuScore + 1;
        }
        else if (playerChoice == 0 && cpuChoice == 0)
        {
            Console.WriteLine("You both choose rock.\n");
            Console.WriteLine("It's a tie.\n");
            numDraws++;
            //numDraws = numDraws + 1;
        }
        else if (playerChoice == 1 && cpuChoice == 1)
        {
            Console.WriteLine("You both choose paper.\n");
            Console.WriteLine("It's a tie.\n");
            numDraws++;
            //numDraws = numDraws + 1;
        }
        else if (playerChoice == 2 && cpuChoice == 2)
        {
            Console.WriteLine("You both choose scissors.\n");
            Console.WriteLine("It's a tie.\n");
            numDraws++;
            //numDraws = numDraws + 1;
        }
        else 
        {
            Console.WriteLine("ERROR.\n");
        }
        
        loopCount++;
        
    }
    Console.WriteLine($"Player Score: {playerScore}\n");
    Console.WriteLine($"CPU Score: {cpuScore}\n");
    Console.WriteLine($"Draws: {numDraws}\n");
  }
}