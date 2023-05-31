using System;
using System.Collections.Generic;
using JourneyThroughUnknown.Entities.Models.Beings;

namespace JourneyThroughUnknown
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string filePath = "../../Maps/Level1.txt";
            
            MapReader mapReader = new MapReader(filePath);

            char[,] map = mapReader.getMap();

            for(int i = 0; i < map.GetLength(0); i++)
            {
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i,j]);
                }

                Console.WriteLine();
            }

            Stack<Player> players = new Stack<Player>();
        }
    }
}