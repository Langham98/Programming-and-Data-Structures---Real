using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonDiceGame
{

    public class GameMenu
    {

        public static void Menu()
        {

            Console.Write("Welcome to the 'Going to Boston' dice game.\n");

            Console.Write("Match Play = mp\nScore Play = sp\nRules = r\n");
           
            Console.WriteLine("What would you like to do?");
            string choice = Console.ReadLine();

            if (choice == "r")
            {
                Rules();
            }
            else if (choice == "sp")
            {
                Console.WriteLine("Going to ScorePlay....");
                Game.sp();
                
            }
            else if (choice == "mp")
            {
                Console.WriteLine("Going to MatchPlay....");
                Game.mp();
            }
            else
            {
                Console.WriteLine("Wrong abbreviation used!");
                Menu();
            }

            Console.ReadKey();

        }


        private static void Rules()
        {
            Console.WriteLine("This is the rules section:");
            Console.WriteLine("The concept of Going to Boston is not complicated. It needs three dice. Roll the three dice and take the highest number from each roll. Each time you roll you lose a die. So the first roll is going to be with three dice, the second with two, and the third with a single die. Total up the three dice, the player with the highest value wins that round.");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("To go back to the Main Menu type (return) or to close the application type (exit)");
            string Return = Console.ReadLine();
            if (Return == "return")
            {
                Menu();
            }
            else if (Return == "exit")
            {
                Environment.Exit(0);
            }

            else
            {
                Rules();
            }
        }


    }

    public class Player
    {
        public static int score1 = 0;
        public static int score2 = 0;
        public static int NumOfPlayers;

        public static int compare1 = 0;
        public static int compare2 = 0;


        public static void Main()
        {
            Console.WriteLine("Please enter the number of players. (Enter 1 or 2)");
            NumOfPlayers = Convert.ToInt32(Console.ReadLine());

            GameMenu.Menu();
            



        }

    }

    public class Die
    {
         static Random dice1 = new Random();


        public static int OneDiceThrow()
        {
            int onediceroll = dice1.Next(1, 7);
            return onediceroll;

        }
        public static int TwoDiceThrow(int a, int b)
        {
            List<int> twodiceroll = new List<int>(2) { a, b };
            int Best2Roll = twodiceroll.Max();
            return Best2Roll;

        }
        public static int ThreeDiceThrow(int a, int b, int c)
        {
            List<int> threediceroll = new List<int>(3) { a, b, c };
            int Best3Roll = threediceroll.Max();
            return Best3Roll;

        }
    }


    public class Game
    {

        public static void sp()
        {
            string[] Names = new string[Player.NumOfPlayers];
            Console.WriteLine("Please enter the names of each player");


            for (int i = 0; i < Player.NumOfPlayers; i++)
            {

                Console.WriteLine("Player " + (i + 1) + "?");
                Names[i] = Console.ReadLine();
                Console.WriteLine();
            }

            List<int> Player1Score = new List<int>();
            List<int> Player2Score = new List<int>();

            int score1 = Player.score1;
            int score2 = Player.score2;
            int currentscore = 0;

           

            

            for (int roundtally = 0; roundtally < 5; roundtally++)
            {
                foreach (string name in Names)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine("Press any key for {0}'s roll...", name);
                    Console.ReadKey();

                    int FirstRoll1 = Die.OneDiceThrow();
                    int FirstRoll2 = Die.OneDiceThrow();
                    int FirstRoll3 = Die.OneDiceThrow();

                    Console.WriteLine("{0}'s first 3 dice rolls are {1}, {2}, {3}", name, FirstRoll1, FirstRoll2, FirstRoll3);

                    int BestFirstRoll = Die.ThreeDiceThrow(FirstRoll1, FirstRoll2, FirstRoll3);

                    currentscore += BestFirstRoll;


                    Console.WriteLine("{0}'s highest dice roll is {1}", name, BestFirstRoll);

                    Console.WriteLine("Press any key to continue to the next roll...");
                    Console.ReadKey();

                    int SecondRoll1 = Die.OneDiceThrow();
                    int SecondRoll2 = Die.OneDiceThrow();

                    Console.WriteLine("{0}'s 2 dice rolls are {1} and {2}", name, SecondRoll1, SecondRoll2);

                    int BestSecondRoll = Die.TwoDiceThrow(SecondRoll1, SecondRoll2);

                    currentscore += BestSecondRoll;

                    Console.WriteLine("{0}'s highest dice roll is {1}", name, BestSecondRoll);

                    Console.WriteLine("Press any key to continue to the next roll...");
                    Console.ReadKey();

                    int ThirdRoll1 = Die.OneDiceThrow();

                    Console.WriteLine("{0}'s 1 dice roll is {1}", name, ThirdRoll1);

                    int BestThirdRoll = ThirdRoll1;

                    currentscore += BestThirdRoll;

                    Console.WriteLine("{0}'s highest dice roll is {1}", name, BestThirdRoll);

                    Console.WriteLine("----------------------");

                    if (score1 > 0)
                    {
                        score2 = BestFirstRoll + BestSecondRoll + BestThirdRoll;
                        Player2Score.Add(score2);
                        
                    }
                    else
                    {
                        score1 = BestFirstRoll + BestSecondRoll + BestThirdRoll;
                        Player1Score.Add(score1);
                       
                    }
                    Console.WriteLine("The total round score for {0} is {1}", name, currentscore);
                    currentscore = 0;
                    Console.WriteLine("-------------------");
                    Console.WriteLine("The round is over. Over to the next player...");

                    Console.WriteLine("Score 1 is {0} | Score 2 is {1}", score1, score2);
                   
                }
                foreach (int points1 in Player1Score)
                {
                   
                    Player.compare1 = points1;
                    Console.WriteLine("The current total for player 1 is {0}", Player.compare1);
                }

                foreach (int points2 in Player2Score)
                {
                    
                    Player.compare2 = points2;
                    Console.WriteLine("The current total for Player 2 is {0}", Player.compare2);
                }

              
            }
            if (Player.compare1 > Player.compare2)
            {
                WinPlayerOne();
            }
            if (Player.compare2 > Player.compare1)
            {
                WinPlayerTwo();
            }
            else
            {
                Console.WriteLine("The Game is a draw. The scores were {0} | {1}", Player.compare1, Player.compare2);
            }

        }

        public static void mp()
        {
            string[] Names = new string[Player.NumOfPlayers];
            Console.WriteLine("Please enter the names of each player");


            for (int i = 0; i < Player.NumOfPlayers; i++)
            {

                Console.WriteLine("Player " + (i + 1) + "?");
                Names[i] = Console.ReadLine();
                Console.WriteLine();
            }
        }

    

    public static void WinPlayerOne()
    {

        {
                Console.WriteLine("Congrats, Player 1 Wins with {0}!", Player.compare1);
            
            string EndText = Console.ReadLine();
            if (EndText == "restart")
            {
                Player.Main();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
        public static void WinPlayerTwo()
        {
            Console.WriteLine("Congrats, Player 2 Wins with {0}!", Player.compare2);
           
            string EndText = Console.ReadLine();
            if (EndText == "restart")
            {
                Player.Main();
            }
            else
            {
                Environment.Exit(0);
            }
        }


    }

}         


            





