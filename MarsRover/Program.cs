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
            /*[Intro]
We're rolling "Suicide"

[Verse: Serj Tankian]
Wake up (Wake up)
Grab a brush and put a little makeup
Hide your scars to fade away the shakeup
(Hide the scars to fade away the)
Why'd you leave the keys upon the table?
Here you go, create another fable
You wanted to!
Grab a brush and put a little makeup
You wanted to!
Hide the scars to fade away the shakeup
You wanted to!
Why'd you leave the keys upon the table?
You wanted to!

[Chorus: Serj Tankian]
I don't think you trust
In my
Self-righteous suicide
I cry
When angels deserve to
DIE!

[Verse: Serj Tankian]
Wake up (Wake up)
Grab a brush and put a little makeup
Hide the scars to fade away the
(Hide the scars to fade away the shakeup)
Why'd you leave the keys upon the table?
Here you go, create another fable
You wanted to!
Grab a brush and put a little makeup
You wanted to!
Hide the scars to fade away the shakeup
You wanted to!
Why'd you leave the keys upon the table?
You wanted to!

[Chorus: Serj Tankian]
I don't think you trust
In my
Self-righteous suicide
I cry
When angels deserve to die
In my
Self-righteous suicide
I cry
When angels deserve to die...

[Bridge: Serj Tankian (& Daron Malakian)]
Father! (Father!) Father! (Father!)
Father! (Father!) Father! (Father!)
Father, into your hands I commend my spirit
Father, into your hands
Why have you forsaken me?
In your eyes, forsaken me?
In your thoughts, forsaken me?
In your heart, forsaken me?

[Chorus/Outro: Serj Tankian]
Oh, trust in my
Self-righteous suicide
I cry
When angels deserve to die
In my
Self-righteous suicide
I cry
When angels deserve to die
    **/

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

        public void moveLeft()
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
