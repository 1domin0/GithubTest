using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 41);

            bool isGameOn = true;
            bool isWallHit = false;
            bool isAppleEaten = false;
            int gameSpeed = 100;
            int[] xPosition = new int[100];
            int[] yPosition = new int[100];
            Random rnd = new Random();
            int xApplePos;
            int yApplePos;

            int applesEaten = 0;


            Console.SetCursorPosition(73, 1);
            Console.Write("Scrore: {0}", applesEaten);
            //generate borders
            GenerateBorders();

            //print snake on screen
            xPosition[0] = 31;
            yPosition[0] = 15;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(xPosition[0], yPosition[0]);
            Console.Write((char)4);

            //print apple on screen
            PrintApple(rnd, out xApplePos, out yApplePos);

            //move snake
            ConsoleKey command = Console.ReadKey().Key;
            do
            {
                switch (command)
                {

                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(xPosition[0], yPosition[0]);
                        Console.Write(" ");
                        xPosition[0]--;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(xPosition[0], yPosition[0]);
                        Console.Write(" ");
                        yPosition[0]--;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(xPosition[0], yPosition[0]);
                        Console.Write(" ");
                        xPosition[0]++;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(xPosition[0], yPosition[0]);
                        Console.Write(" ");
                        yPosition[0]++;
                        break;
                }
                //detect when apple was eaten
                isAppleEaten = DetermineIfAppleWasEaten(xPosition[0], yPosition[0], xApplePos, yApplePos);

                //print an apple on screen
                if (isAppleEaten)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    applesEaten++;
                    Console.SetCursorPosition(73, 1);
                    Console.Write("Scrore: {0}", applesEaten);
                    PrintApple(rnd, out xApplePos, out yApplePos);
                }

                //paint the snake

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(xPosition[0], yPosition[0]);
                Console.Write((char)4);

                //detect hit the wall
                isWallHit = DidSnakeHitWall(xPosition[0], yPosition[0]);
                if (isWallHit)
                {
                    isGameOn = false;
                    Console.SetCursorPosition(31, 15);
                    Console.Write("The snake hit the wall.");
                }

                //game speed
                if (Console.KeyAvailable) command = Console.ReadKey().Key;
                System.Threading.Thread.Sleep(gameSpeed);
            } while (isGameOn);

            Console.ReadKey();
        }

        static void PrintApple(Random random, out int xApplePos, out int yApplePos)
        {
            xApplePos = random.Next(2, 60);
            yApplePos = random.Next(2, 30);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xApplePos, yApplePos);
            Console.Write((char)214);
        }
        static bool DetermineIfAppleWasEaten(int xPosition, int yPosition, int xApplePos, int yApplePos)
        {
            if (xPosition == xApplePos && yPosition == yApplePos)
                return true;
            else
                return false;
        }


        private static bool DidSnakeHitWall(int xPosition, int yPosition)
        {
            if (xPosition == 1 || xPosition == 61 || yPosition == 1 || yPosition == 31)
                return true;
            else
                return false;
        }

        static void GenerateBorders()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            //top border
            for (int i = 1; i < 62; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("@");
            }
            //bottom border
            for (int i = 1; i < 62; i++)
            {
                Console.SetCursorPosition(i, 31);
                Console.Write("@");
            }
            //left border
            for (int i = 1; i < 31; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("@");
            }
            //right border
            for (int i = 1; i < 31; i++)
            {
                Console.SetCursorPosition(61, i);
                Console.Write("@");
            }
        }
    }
}
