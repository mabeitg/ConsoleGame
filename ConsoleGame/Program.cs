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

            List<Enemy> enemies = new List<Enemy>();//Lista med fiender

            Random rng = new Random();//Slumpgenerator

            //Lägger till fiender i listan
            for (int i = 0; i < 200; i++)
            {
                Enemy newEnemy = new Enemy();
                newEnemy.positionX = rng.Next(0, 181);
                newEnemy.positionY = rng.Next(0, 40);

                enemies.Add(newEnemy);
            }


            //Enemy koopa = new Enemy();
            //koopa.positionX = 10;
            //koopa.positionY = 20; 


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
                    
                    //Loopar igenom fiendelistan och uppdaterar och ritar varje fiende i listan
                    //for (int i = 0; i < enemies.Count; i++)
                    //{
                    //    enemies[i].Update();
                    //    enemies[i].Draw();
                    //}

                    //Smidigt sätt att loopa igenom hel lista. 
                    //foreach(Typ tempNamn in listansNamn)
                    foreach(Enemy enemy in enemies)
                    {
                        enemy.Update();
                        enemy.Draw();
                    }

                    gameTime.Restart(); //Startar om timern
                }
            }            
        }
    }
}
