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
        Random rand = new Random();

        public enum TileType
        {
            Player,
            Field,
            Mountain,
            Water,
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
                map.Add(rand.Next(1, 6));
                for(int j = 0; j >= Height; j++)
                {
                    //add items to map height?
                    map.Add(rand.Next(1, 6));
                }
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Update(int i)
        {
            
        }

        public void Update(char c)
        {
            throw new NotImplementedException();
        }
    }
}
