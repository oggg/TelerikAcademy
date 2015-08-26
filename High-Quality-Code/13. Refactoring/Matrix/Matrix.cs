using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix
    {
        private const int MIN_DIMENSION = 1;
        private const int MAX_DIMENSION = 100;
        private readonly List<MatrixCell> directions = new List<MatrixCell>
                                                      {
                                                          new MatrixCell(1, 1),
                                                          new MatrixCell(1, 0),
                                                          new MatrixCell(1, -1),
                                                          new MatrixCell(0, -1),
                                                          new MatrixCell(-1, -1),
                                                          new MatrixCell(-1, 0),
                                                          new MatrixCell(-1, 1),
                                                          new MatrixCell(0, 1)
                                                      };

        private readonly int[,] matrix;
        private int currentDirection;

        public Matrix(int dimension)
        {
            if (dimension < MIN_DIMENSION || MAX_DIMENSION < dimension)
            {
                throw new ArgumentOutOfRangeException("Matrix dimensions are out of ranges");
            }

            this.matrix = new int[dimension, dimension];
            this.currentDirection = 0;
            this.FillMatrix();
        }

        private void FillMatrix()
        {
            MatrixCell currentCell = new MatrixCell(0, 0);
            int currentValue = 1;

            do
            {
                this.matrix[currentCell.Row, currentCell.Column] = currentValue;
                currentCell = this.Move(currentCell) ?? this.AvailableCell();
                currentValue++;
            } while (currentCell != null);
        }

        private MatrixCell Move(MatrixCell cell)
        {
            for (int i = currentDirection; i < this.directions.Count + this.currentDirection; i++)
            {
                var newCell = cell + this.directions[i % this.directions.Count];
                if (this.CheckCellInMatrix(newCell) && (this.matrix[newCell.Row, newCell.Column] == 0))
                {
                    this.currentDirection = i % this.directions.Count;
                    return newCell;
                }
            }
            return null;
        }

        private bool CheckCellInMatrix(MatrixCell cell)
        {
            return cell.Row >= 0 && cell.Row < this.matrix.GetLength(0) && cell.Column >= 0
                   && cell.Column < this.matrix.GetLength(1);
        }

        private MatrixCell AvailableCell()
        {
            var cell = new MatrixCell(0, 0);

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    if (this.matrix[i,j] == 0)
                    {
                        cell.Row = i;
                        cell.Column = j;
                        this.currentDirection = 0;
                        return cell;                          
                    }
                }
            }
            return null;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (var j = 0; j < this.matrix.GetLength(0); j++)
                {
                    sb.Append(string.Format("{0,3}", this.matrix[i, j]));
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

    }
}
