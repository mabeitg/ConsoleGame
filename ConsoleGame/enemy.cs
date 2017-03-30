using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleGame
{
    class Enemy
    {
        //<---Variabler--->

        public string sprite = "#";
        public int positionX, positionY;
        private int oldPositionX, oldPositionY;
        private int velocityX=2, velocityY=1;

        //<---Metoder--->

        //Ritar ut på skärmen
        public void Draw()
        {
            //Suddar i gamla positionen
            Console.SetCursorPosition(oldPositionX, oldPositionY);
            Console.Write(" ");

            //Ritar i nya positionen
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(sprite);
        }

        //Spellogik
        public void Update()
        {

            //Lagrar gamla positionen
            oldPositionX = positionX;
            oldPositionY = positionY;

            //Flyttar spelaren
            positionX += velocityX;
            positionY += velocityY;

            if (positionX < 0)
                positionX = 0;

            if (positionY < 0)
                positionY = 0;

            if (positionX > Program.WindowWidth - 1)
                positionX = Program.WindowWidth - 2;

            if (positionY > Program.WindowHeight - 1)
                positionY = Program.WindowHeight - 1;

        }
    }
}