using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class MatrixCell
    {
        private static int MIN_LENGTH = 1;
        private static int MAX_LENGTH = 100;

        public int Row { get; set; }
        public int Column { get; set; }

        public MatrixCell(int x, int y)
        {
            this.Row = x;
            this.Column = y;
        }

        public static MatrixCell operator +(MatrixCell firstCell, MatrixCell secondCell)
        {
            return new MatrixCell(firstCell.Row + secondCell.Row, firstCell.Column + secondCell.Column);
        }
    }
}
