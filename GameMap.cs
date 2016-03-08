using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RogueGame
{
    public class GameMap : IUpdatable
    {
        public static int Width = 25;
        public static int Height = 25;

        List<int> map;

        public enum TileType
        {
            Field,
            Mountain,
            Water,
            Player,
            Enemy,
            Boss,
            Item,
        }

        public GameMap()
        {
            map = new List<int>();
            for(int i = 0; i >= Width; i++)
            {
                //add items to map width?
                for(int j = 0; j >= Height; j++)
                {
                    //add items to map height?
                }
            }
        }

        public void Update()
        {
            map.
        }
        
        public void Update(char c)
        {
            throw new NotImplementedException();
        }
    }
}
