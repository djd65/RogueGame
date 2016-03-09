using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGame
{
    public class MapObject
    {
        public int XPosition;
        public int YPosition;
    }

    class BadGuy : MapObject, IUpdatable, IMoveable
    {
        public int Health { get; set; }
        public int Mana { get; set; }

        public void Update()
        {

        }

        public void Update(int i)
        {
            throw new NotImplementedException();
        }

        public void Update(char key)
        {
            throw new NotImplementedException();
        }

        public void UpdateXPosition()
        {

        }

        public void UpdateYPosition()
        {

        }
    }
}
