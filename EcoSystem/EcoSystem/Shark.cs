using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Shark : Fish
    {
        public int _timeToDie;
        public int _livingTime;
        public delegate void FishDeth(Coordinate pos);
        public delegate bool isFood(Coordinate pos);
        public FishDeth Die;
        public isFood canEat;
        public Shark(Coordinate pos, SwimDeleg d, MakeFish mkF, FishDeth fd, isFood ifd, int liveTime = 12) : base(pos, d, mkF)
        {
            SetCellSimbol('S');
            _livingTime = liveTime;
            _timeToDie = liveTime;
            Die = fd;
            canEat = ifd;
        }
        public void Eat()
        {

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
            if (canEat(newPosition))
            {
                Die(newPosition);
                _timeToDie = _livingTime;
            }

            if (_timeToDie == 0)
            {
                Die(_position); 
            }
            else
            {
                _timeToDie--;
                if (_currentTimeToREprouce == 0)
                {
                    _reproduce(newPosition, _simbol);
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
}
