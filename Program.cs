namespace Simple_Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("^^^^^^^__ Welcome to Dice_Game --^^^^^^^^^");
            //delay 1 S
            System.Threading.Thread.Sleep(1000);
            Random random = new Random();
            int player = 0;
            int player_score = 0;
            int AI = 0;
            int AI_score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\nPress any key to roll the Dice \n ->");
                Console.ReadKey();
                // generate random number from 1 to 6 for Player
                player = random.Next(1, 7);
                Console.WriteLine($"you rolled : {player}");
                Console.WriteLine(".....");
                // generate random number from 1 to 6 for AI
                AI = random.Next(1, 7);
                //delay 800 mS
                System.Threading.Thread.Sleep(800);
                Console.WriteLine($"AI rolled : {AI}\n");
                // adding score for round winner
                if(player == AI)
                {
                    Console.WriteLine("Draw!");
                }else if(player > AI) {

                    player_score++;
                    Console.WriteLine("You Wins ^_^ ");
                }
                else
                {
                    AI_score++;
                    Console.WriteLine("AI Wins -_- ");
                }
                Console.WriteLine($"Score you:{player_score} , AI:{AI_score}\n");
            }
            Console.Write("Game Over \n ->");
            if(player_score > AI_score) {
                Console.WriteLine("You Won $$$");
            }
            else if (player_score < AI_score)
            {
                Console.WriteLine("AI won ***");
            }
            else
            { 
                Console.WriteLine("no one won !");
            }
            Console.ReadKey();
        }
    }
}