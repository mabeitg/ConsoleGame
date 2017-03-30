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
        private int positionX, positionY;
        private int oldPositionX, oldPositionY;
        private int velocityX, velocityY;
        private int health=7;

        //<---Egenskaper/Properties--->
        //En egenskap är en eller två metoder som utifrån
        //"ser ut" som variabler

        public int PositionX
        {
            get
            {
                return positionX;
            }
            set
            {
                if (value >= 0)
                    positionX = value;
                else
                    positionX = 0;
            }
        }

        public int PositionY
        {
            get
            {
                return positionY;
            }
            set
            {
                if (value >= 0)
                    positionY = value;
                else
                    positionY = 0;
            }
        }

        public int Health
        { get { return health; } }

        public bool IsAlive
        {
            get
            {
                if (health > 0)
                    return true;
                else
                    return false;
            }
        }

        public double K
        {
            get
            {
                return velocityY / (double)velocityX;
            }
        }

        private string Healthbar
        {
            get
            {
                string healthbar = "";

                for (int i = 0; i < health; i++)
                {
                    healthbar += "x";
                }

                for (int i = 0; i < 10 - health; i++)
                {
                    healthbar += "-";
                }
                return healthbar;
            }
        }

        //<---Metoder--->

        //Ritar ut på skärmen
        public void Draw()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(Healthbar);

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

                //Lagrar gamla positionen
                oldPositionX = positionX;
                oldPositionY = positionY;

                //Flyttar spelaren
                positionX += velocityX;
                positionY += velocityY;

                //Nollar hastighet
                velocityX = 0;
                velocityY = 0;
            }
        }
        
        //Gör en healthbar med x för liv och - för inte liv
/*        private string Healthbar()
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
        */
    }
}