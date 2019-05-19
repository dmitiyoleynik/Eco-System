using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Ocean
    {
        Cell[,] _area;
        int _size;
        int _row;
        int _column;
        int _fishNumber;
        int _sharksNumber;
        Random _random;

        public Ocean(int colum, int row)
        {
            _column = colum;
            _row = row;
            _size = _row * _column;
            _area = new Cell[_row, _column];
            Random _random = new Random();//i should redo it
            SetCells();
        }
        public void SetCells()
        {
            Random _random = new Random();
            for (int i = 0; i < _row - 1; i++)
            {
                for (int j = 0; j < _column - 1; j++)
                {
                    switch (_random.Next(1, 20))
                    {
                        case 1:
                            _area[i, j] = new Fish(new Coordinate(i, j), Swop);
                            break;
                        case 2:
                            _area[i, j] = new Shark(new Coordinate(i, j), Swop);
                            break;
                        case 5:
                            _area[i, j] = new Block(new Coordinate(i, j));
                            break;
                        default:
                            _area[i, j] = new Cell(new Coordinate(i, j));
                            break;
                    }
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < _row - 1; i++)
            {
                for (int j = 0; j < _column - 1; j++)
                {
                    _area[i, j].Display();
                }
                Console.WriteLine();
            }
        }
        public void Run()
        {
            for (int i = 0; i < _row - 1; i++)
            {
                for (int j = 0; j < _column - 1; j++)
                {
                    if (_area[i, j]._simbol == 'f')
                    {
                        ((Fish)_area[i, j]).Move();
                    }
                    if (_area[i, j]._simbol == 'S')
                    {
                        ((Shark)_area[i, j]).Move();
                    }
                }
            }
        }
        public void KillFish(Coordinate pos)
        {
            _area[pos._x,pos._y] = new Cell(pos);
        }
        public void Swop(Coordinate fishPosition, Coordinate whereItWantsToSwim)
        {
            if (whereItWantsToSwim._x >= 0 && whereItWantsToSwim._x < _row - 1 &&
                whereItWantsToSwim._y >= 0 && whereItWantsToSwim._y < _column - 1&&
                !(_area[whereItWantsToSwim._x,whereItWantsToSwim._y] is Block))
            {
                Cell tmp;
                tmp = _area[fishPosition._x, fishPosition._y];
                _area[fishPosition._x, fishPosition._y] = _area[whereItWantsToSwim._x, whereItWantsToSwim._y];
                _area[whereItWantsToSwim._x, whereItWantsToSwim._y] = tmp;

                Coordinate posTmp;
                posTmp = _area[fishPosition._x, fishPosition._y]._position;
                _area[fishPosition._x, fishPosition._y]._position = _area[whereItWantsToSwim._x, whereItWantsToSwim._y]._position;
                _area[whereItWantsToSwim._x, whereItWantsToSwim._y]._position = posTmp;
            }
        }
    }
}
