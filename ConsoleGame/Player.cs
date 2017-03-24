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
        private int health=7;

        //<---Metoder--->

        //Ritar ut på skärmen
        public void Draw()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(Healthbar());

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
        
        //Gör en healthbar med x för liv och - för inte liv
        private string Healthbar()
        {
            string healthbar = "";

            for(int i =0;i<health;i++)
            {
                healthbar += "x";
            }

            for(int i =0;i<10-health;i++)
            {
                healthbar += "-";
            }
            return healthbar;
        }
    }
}