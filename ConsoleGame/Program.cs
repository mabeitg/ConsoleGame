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
            Player mario2 = new Player();

            mario.positionX = 2;
            mario.positionY = 1;

            //Tidtagning för att kolla koll på hur ofta spelet uppdateras
            Stopwatch gameTime = new Stopwatch();
            gameTime.Start();

            //Spel-loop
            while(true)
            {
                if (gameTime.ElapsedMilliseconds >= 10)
                {
                    Console.Clear();    //Tömmer skärmen
                    mario.Draw();
                    mario.Update();
                    gameTime.Restart(); //Startar om timern
                }
            }            
        }
    }
}
