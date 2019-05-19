using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Cell
    {
        public char _simbol;
        public Coordinate _position;
        public Cell(Coordinate pos)
        {
            _position = pos;
            SetCellSimbol('-');
        }
        public void SetCellSimbol(char simbol)
        {
            _simbol = simbol;
        }
        public void Display()
        {
            Console.Write(_simbol);
        }
        
    }
}
