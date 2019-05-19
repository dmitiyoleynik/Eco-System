using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Fish : Cell
    {
        public delegate void SwimDeleg(Coordinate fishPosition, Coordinate whereItWantsToSwim);
        public delegate void MakeFish(Coordinate pos,char type);
        public MakeFish _reproduce;
        public SwimDeleg _fishSwap;
        public Random _random;
        public int _timeToReproduce;
        public int _currentTimeToREprouce;
        public Fish(Coordinate pos, SwimDeleg d,MakeFish rep,int reproduce=15) : base(pos)
        {
            SetCellSimbol('f');
            _fishSwap = d;
            _random = new Random();
            _timeToReproduce = reproduce;
            _currentTimeToREprouce = _timeToReproduce;
            _reproduce = rep;
        }
        virtual public void Move()
        {
            Coordinate newPosition=new Coordinate(0,0);

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
                    newPosition= new Coordinate(_position._x - 1, _position._y);
                    break;
            }
            if (_currentTimeToREprouce == 0)
            {
                _reproduce(newPosition,_simbol);
                _currentTimeToREprouce = _timeToReproduce;
            }
            else
            {
                _fishSwap(_position, newPosition);
                _currentTimeToREprouce--;
            }
            
        }
    }
}
