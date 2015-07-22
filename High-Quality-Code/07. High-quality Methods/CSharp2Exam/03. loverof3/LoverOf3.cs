using System;

class LoverOf3
{
    static void Main()
    {
        int[] matrixDimensions = Array.ConvertAll((Console.ReadLine()).Split(' '), int.Parse);
        int numberOfDirections = int.Parse(Console.ReadLine());
        bool[,] visitedMatrix = InitializeBoolMatrix(matrixDimensions[0], matrixDimensions[1]);
        int finalSum = 0;
        int currentRow = visitedMatrix.GetLength(0) - 1;
        int currentCol = 0;
        int[] moves = new int[numberOfDirections];
        string[] directions = new string[numberOfDirections];

        for (int p = 0; p < numberOfDirections; p++)
        {
            string dir = Console.ReadLine();
            moves[p] = int.Parse(dir.Split(' ')[1]);
            directions[p] = dir.Split(' ')[0];
        }

        for (int i = 0; i < numberOfDirections; i++)
        {
            //string currentDirection = Console.ReadLine().Split(' ')[0];
            //int currentMoves = int.Parse(Console.ReadLine().Split(' ')[1]);
            int currentMoves = moves[i];
            string currentDirection = directions[i];
            for (int j = 0; j < currentMoves - 1; j++)
            {
                switch (currentDirection)
                {
                    case "RU":
                    case "UR":
                        {
                            if (currentRow == 0 || currentCol == matrixDimensions[1] - 1)
                            {
                                break;
                            }
                            currentRow--;
                            currentCol++;
                            break;
                        }
                    case "LU":
                    case "UL":
                        {
                            if (currentRow == 0 || currentCol == 0)
                            {
                                break;
                            }
                            currentRow--;
                            currentCol--;
                            break;
                        }
                    case "DL":
                    case "LD":
                        {
                            if (currentRow == matrixDimensions[0] - 1 || currentCol == 0)
                            {
                                break;
                            }
                            currentRow++;
                            currentCol--;
                            break;
                        }
                    case "RD":
                    case "DR":
                        {
                            if (currentRow == matrixDimensions[0] - 1 || currentCol == matrixDimensions[1] - 1)
                            {
                                break;
                            }
                            currentRow++;
                            currentCol++;
                            break;
                        }
                }

                bool visitedCell = visitedMatrix[currentRow, currentCol];
                if (visitedCell)
                {
                    continue;
                }
                else
                {
                    finalSum += MatrixValues(currentRow, currentCol, matrixDimensions[0]);
                }

                visitedMatrix[currentRow, currentCol] = true;

                if (currentRow == 0
                        || currentRow == matrixDimensions[0] - 1
                        || currentCol == 0
                        || currentCol == matrixDimensions[1] - 1)
                {
                    break;
                }
            }
        }
        Console.WriteLine(finalSum);
    }

    static bool[,] InitializeBoolMatrix(int rows, int cols)
    {
        bool[,] matrix = new bool[rows, cols];

        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < cols; k++)
            {
                matrix[j, k] = false;
            }
        }
        return matrix;
    }

    static int MatrixValues(int matrixRow, int matrixCol, int rows)
    {
        int cellValue = (rows - matrixRow - 1 + matrixCol) * 3;
        return cellValue;
    }

}
