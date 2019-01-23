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
            //hello me old chum
            Console.Write("╗");
            for (int i = 1; i < grootteY; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("║");
            }
            //im gnot a gnelf
            Console.SetCursorPosition(0, grootteY);
            Console.Write("╚");
            for (int i = 1; i < grootteY; i++)
            {
                Console.SetCursorPosition(grootteX, i);
                Console.Write("║");
            }
            //im gnot a gnoblin
            Console.SetCursorPosition(grootteX, grootteY);
            Console.Write("╝");
            for (int i = 1; i < grootteX; i++)
            {
                Console.SetCursorPosition(i, grootteY);
                Console.Write("═");
            }
        }
        //but im a gnome
    }
}
// AND YOUVE BEEN GNOMED
