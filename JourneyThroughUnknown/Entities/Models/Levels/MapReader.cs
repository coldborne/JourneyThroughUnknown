using System;
using System.Collections.Generic;
using System.IO;

namespace JourneyThroughUnknown
{
    public class MapReader
    {
        private StreamReader _streamReader;
        
        public MapReader(string filePath)
        {
            _streamReader = new StreamReader(filePath);
        }

        public char[,] getMap(){
            List<char[]> map = new List<char[]>();
            String line;

            while ((line = _streamReader.ReadLine()) != null){
                map.Add(line.ToCharArray());
            }

            char[,] result = new char[map.Count, map[0].Length];

            for (int i = 0; i < map.Count; i++){
                for (int j = 0; j < map[0].Length; j++) {
                    result[i,j] = map[i][j];
                }
            }

            return result;
        }
    }
}


