﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MarsRover
{
    class Mars
    {
      public int grootteX = 40;
        public int grootteY = 20;
        bool[,] arrayrotsen = new bool[40,20];
        public int aantalkeerboren = 3;


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
            Console.WriteLine("         #Boren: " + aantalkeerboren);

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
            //StreamWriter writer = new StreamWriter("CoordinatesRocks.txt");

            for (int i = 0; i < 10; i++)
            {
                arrayrotsen[random.Next(1, 39),random.Next(1, 19)] = true;
            }
           
        }
    }

        class GenerateWater
        {
            int Xmax;
            int Ymax;
            int kans;
            bool[,] waterplaatsen;
            Random Generate = new Random();

            public GenerateWater(int x, int y)
            {

                waterplaatsen = new bool[x, y];
                Xmax = x;
                Ymax = y;
            }

            public void Plaats()
            {
                for (int i = 1; i < Xmax - 1; i++)
                {
                    for (int j = 1; j < Ymax - 1; j++)
                    {
                        kans = Generate.Next(0, 10);
                        if (kans == 1)
                        {
                            waterplaatsen[i, j] = true;
                        }
                        else { waterplaatsen[i, j] = false; }
                    }
                }
            }
            public void WaterZien()
            {
                for (int i = 1; i < Xmax - 1; i++)
                {
                    for (int j = 1; j < Ymax - 1; j++)
                    {
                        if (waterplaatsen[i, j] == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.SetCursorPosition(i, j);
                            Console.Write("%");
                        }

                    }
                }
            }
            public void WaterNietZien()
            {
                for (int i = 1; i < Xmax - 1; i++)
                {
                    for (int j = 1; j < Ymax - 1; j++)
                    {
                        if (waterplaatsen[i, j] == true)
                        {
                            Console.Write(" ");
                        }

                    }
                }
            }
        }
    
}
