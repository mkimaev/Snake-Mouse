using System;
using System.Threading;

namespace SnakeAndMouse
{
    partial class Program
    {
        class Mouse
        {
            public string Name { get; set; }
            public static int X { get; set; } = 0; //position X
            public static int Y { get; set; } = 0; //position Y
            public event Action Went;
            public Mouse(string name)
            {
                Name = name;
            }
            /// <summary>
            /// moving of mouse
            /// </summary>
            public void GoMouse()
            {

                Random r = new Random(); //genetarate a random number
                X = r.Next(80);
                Y = r.Next(30);
                Console.SetCursorPosition(X, Y); // set position at our console
                Console.Write("mouse");
                Program.count--; //decrement number of moves
                Thread.Sleep(100);
                if (Went != null)
                {
                    Went();// invoke
                }
            }
        }
    }
}
