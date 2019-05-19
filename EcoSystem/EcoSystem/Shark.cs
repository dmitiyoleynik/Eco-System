using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Shark:Fish
    {
        public Shark(Coordinate pos, SwimDeleg d) : base(pos,d)
        {
            SetCellSimbol('S');
        }
        virtual public void Move()
        {
            Coordinate newPosition = new Coordinate(0, 0);

            switch (_random.Next(0, 4))
            {
                case 0:
                    newPosition = new Coordinate(_position._x, _position._y + 1);
                    break;
                case 1:
                    newPosition = new Coordinate(_position._x + 1, _position._y);
                    break;
                case 2:
                    newPosition = new Coordinate(_position._x, _position._y - 1);
                    break;
                case 3:
                    newPosition = new Coordinate(_position._x - 1, _position._y);
                    break;
            }

            _fishSwap(_position, newPosition);
        }
    }
}
