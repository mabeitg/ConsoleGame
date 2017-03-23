using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleGame
{
    class Player
    {
        //<---Variabler--->

        public string sprite = "o";
        public int positionX, positionY;
        private int velocityX, velocityY;
        private int health;

        //<---Metoder--->

        //Ritar ut på skärmen
        public void Draw()
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(sprite);
        }

        //Spellogik
        public void Update()
        {
            if (Console.KeyAvailable)
            {
                //Sparar knapptryckning
                char pressedKey = Console.ReadKey(true).KeyChar;

                //Styrning
                if (pressedKey == 'w')
                    velocityY = -1;

                if (pressedKey == 'a')
                    velocityX = -1;

                if (pressedKey == 's')
                    velocityY = 1;

                if (pressedKey == 'd')
                    velocityX = 1;

                //Flyttar spelaren
                positionX += velocityX;
                positionY += velocityY;

                //Nollar hastighet
                velocityX = 0;
                velocityY = 0;
            }
        }
    }
}
