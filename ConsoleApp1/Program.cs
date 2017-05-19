using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndMouse
{
    delegate void GoHandler(); //delegate

    partial class Program
    {
        public static int count = 100; //number of moves
        

        static void Main(string[] args)
        {
            Mouse mouse = new Mouse("Mikki Mouse");
            Snake piton = new Snake("Kaa");
            mouse.Went += () => { Console.ForegroundColor = ConsoleColor.Cyan; }; // use lambda expression
            mouse.Went += piton.GoSnake;
            piton.snakeWent += () => { Console.ForegroundColor = ConsoleColor.Yellow; }; // use lambda expression
            piton.snakeWent += mouse.GoMouse;
            mouse.GoMouse(); // let's go!
        }

        
    }
}
