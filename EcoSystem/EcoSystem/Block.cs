using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Block:Cell
    {
        public Block(Coordinate pos) : base(pos)
        {
            SetCellSimbol('#');
        }
    }
}
