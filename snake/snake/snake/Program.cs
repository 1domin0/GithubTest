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
            int gameSpeed = 100;
            int xPosition = 31, yPosition = 15;
            Random rnd = new Random();
            int xApplePos;
            int yApplePos;

            //generate borders
            GenerateBorders();

            //spawn snake
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(xPosition, yPosition);
            Console.Write((char)4);


            //move snake
            ConsoleKey command = Console.ReadKey().Key;
            do
            {
                switch (command)
                {

                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(xPosition, yPosition);
                        Console.Write(" ");
                        xPosition--;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(xPosition, yPosition);
                        Console.Write(" ");
                        yPosition--;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(xPosition, yPosition);
                        Console.Write(" ");
                        xPosition++;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(xPosition, yPosition);
                        Console.Write(" ");
                        yPosition++;
                        break;
                }

                //print snake
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(xPosition, yPosition);
                Console.Write((char)4);

                //detect hit the wall
                isWallHit = DidSnakeHitWall(xPosition, yPosition);
                if (isWallHit)
                {
                    isGameOn = false;
                    Console.SetCursorPosition(31, 15);
                    Console.Write("The snake hit the wall.");
                }

                //print an apple on screen
                PrintApple(rnd, out xApplePos, out yPosition);

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
            Console.SetCursorPosition(xApplePos, yApplePos);
            Console.Write((char)214);
            Console.ForegroundColor = ConsoleColor.Red;
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
}
