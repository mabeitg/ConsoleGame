using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ställer in fönstret
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.CursorVisible = false;

            //Skapar objekt av typen Player.
            //Deklarerar först, initierar sedan
            Player mario = new Player();
            mario.positionX = 2;
            mario.positionY = 1;

            Stopwatch gameTime = new Stopwatch();
            gameTime.Start();
            //Spel-loop
            while(true)
            {
                if (gameTime.ElapsedMilliseconds >= 20)
                {
                    Console.Clear();
                    mario.Draw();
                    mario.Update();
                    gameTime.Restart();
                }
            }            
        }
    }
}
