using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed; // mars :-)
            Console.Clear();
            Console.CursorVisible = false; // cursor weg

            Mars mars = new Mars();
            InSight rover = new InSight();
            rover.ToonInSight();
            mars.toonMars();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var command = Console.ReadKey().Key;

                    switch (command)
                    {
                        case ConsoleKey.DownArrow:
                            rover.moveDown();
                            break;
                        case ConsoleKey.UpArrow:
                            rover.moveUp();
                            break;
                        case ConsoleKey.LeftArrow:
                            rover.moveLeft();
                            break;
                        case ConsoleKey.RightArrow:
                            rover.moveRight();
                            break;
                    }
                    Console.Clear();
                    rover.ToonInSight();
                    mars.toonMars();

                }
            }
        }
    }

    class InSight
    {
        char symbool = '#';
        ConsoleColor kleur = ConsoleColor.Yellow;
        int posX = 1;
        int posY = 1;

        public InSight()
        {

        }

        public InSight(char symbool, ConsoleColor kleur)
        {
            this.symbool = symbool;
            this.kleur = kleur;
        }

        public void moveUp()
        {
            if (posY > 0)
            {
                posY--;
            }
        }

        public void moveDown()
        {
            posY++;
        }

        public void moveLeft() //paddenstoel
        {
            if (posX > 0)
            {
                posX--;
            }
        }

        public void moveRight()
        {
            posX++;
        }

        public void ToonInSight()
        {
            if (posX >= 0 && posY >= 0) 
            {
                Console.ForegroundColor = kleur;
                Console.SetCursorPosition(posX, posY);
                Console.Write(symbool);
            }
        }

    }
}
