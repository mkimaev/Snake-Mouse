using System;
using System.Threading;

namespace SnakeAndMouse
{
    partial class Program
    {
        class Snake
        {
            public string Name { get; set; }
            public int X { get; set; } = 0; //position X
            public int Y { get; set; } = 0; //position Y
            public event GoHandler snakeWent;
            public Snake(string name)
            {
                Name = name;
            }
            /// <summary>
            /// moving of snake
            /// </summary>
            public void GoSnake()
            {
                if (Program.count < 0)
                {
                    X = Mouse.X; //assign position value X
                    Y = Mouse.Y; //assign position value Y
                    Console.SetCursorPosition(X, Y);
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("snake cъел mouse!");
                    Console.ReadKey();
                    return;
                }
                X = Mouse.X; //assign position value X
                Y = Mouse.Y+1; //assign position value Y
                Program.count--; //decrement number of moves
                Console.SetCursorPosition(X, Y); // set position at our console
                Console.WriteLine("snake");
                Thread.Sleep(100);
                if (snakeWent != null)
                {
                    snakeWent();
                } 
            }
        }
    }
}
