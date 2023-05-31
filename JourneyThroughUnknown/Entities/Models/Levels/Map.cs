namespace JourneyThroughUnknown.Entities.Models
{
    public class Map {
        private char[][] _map;

        public Map(char[][] map){
            _map = map;
        }

        public char[][] getMap(){
            return _map;
        }
    }
}


