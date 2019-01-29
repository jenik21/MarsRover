using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Mars
    {
        int grootteX = 40;
        int grootteY = 20;
        bool[,] arrayrotsen = new bool[40,20];

        public Mars()
        {
            RotsenGenereren();
            RotsenTonen();
        }

        //Maakt een omgeving waarin je kan bewegen (in de console)
        public void toonMars()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
            Console.Write("╔");
            for (int i = 1; i < grootteX; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("═");
            }
            Console.Write("╗");
            for (int i = 1; i < grootteY; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("║");
            }
            Console.SetCursorPosition(0, grootteY);
            Console.Write("╚");
            for (int i = 1; i < grootteY; i++)
            {
                Console.SetCursorPosition(grootteX, i);
                Console.Write("║");
            }
            Console.SetCursorPosition(grootteX, grootteY);
            Console.Write("╝");
            for (int i = 1; i < grootteX; i++)
            {
                Console.SetCursorPosition(i, grootteY);
                Console.Write("═");
            }


        }

        public void RotsenTonen() // YANNICK: Spawn rotsen op random locatie binnen gebied //This is torture
        {
            for (int i = 0; i < arrayrotsen.GetLength(0); i++)
            {
                for (int l = 0; l < arrayrotsen.GetLength(1); l++)
                {
                    if (arrayrotsen[i,l] == true)
                    {
                        char charrots = '£';
                        Console.SetCursorPosition(i, l);
                        Console.WriteLine(charrots);
                    }
                    

                }
            }
        }

        public void RotsenGenereren()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                arrayrotsen[random.Next(1, 39),random.Next(1, 19)] = true;
            }
           

        }
    }
}
