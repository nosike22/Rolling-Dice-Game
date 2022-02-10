using System;

namespace Dice_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserRandomNum;
            int OpponentRandomNum;
            int UserScore = 0;
            int OpponentScore = 0;

            Random random = new Random();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press Enter to roll a dice");
                Console.ReadKey();


                UserRandomNum = random.Next(1, 8);
                Console.WriteLine(" You rolled a " + UserRandomNum);

                OpponentRandomNum = random.Next(1, 8);
                Console.WriteLine(" Opponent rolled " + OpponentRandomNum);

                Console.ReadKey();
                if (UserRandomNum > OpponentRandomNum)
                {
                    UserScore++;
                    Console.WriteLine("User has won this round");
                }
                else if (OpponentRandomNum > UserRandomNum)
                {
                    OpponentScore++;

                    Console.WriteLine("Opponent has won this round");

                }
                else
                {
                    Console.WriteLine("Draw");
                }


            }

        }
    }
}
