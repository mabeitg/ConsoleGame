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
        public static int WindowWidth = 200, WindowHeight = 50;

        static void Main(string[] args)
        {
            
            //Ställer in fönstret
            Console.SetWindowSize(WindowWidth, WindowHeight);
            Console.CursorVisible = false;

            //Skapar objekt av typen Player.
            //Deklarerar först, initierar sedan
            Player mario = new Player();

            mario.PositionX = 2;
            mario.PositionY = 1;

            Enemy koopa = new Enemy();
            koopa.positionX = 3;
            koopa.positionY = 2;

            //Tidtagning för att kolla koll på hur ofta spelet uppdateras
            Stopwatch gameTime = new Stopwatch();
            gameTime.Start();

            //Spel-loop
            while(true)
            {
                if (gameTime.ElapsedMilliseconds >= 20)
                {
                    //Console.Clear();    //Tömmer skärmen
                    mario.Draw();
                    mario.Update();
                    koopa.Draw();
                    koopa.Update();

                    gameTime.Restart(); //Startar om timern
                }
            }            
        }
    }
}
