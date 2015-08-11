using System;

namespace Matrix
{
    class WalkInMatrix
    {
        static void change(ref int dx, ref int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };


            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;
            for (int count = 0; count < 8; count++)
                if (dirX[count] == dx && dirY[count] == dy) { cd = count; break; }
            if (cd == 7) { dx = dirX[0]; dy = dirY[0]; return; }
            dx = dirX[cd + 1];


            dy = dirY[cd + 1];
        }
        static bool proverka(int[,] theMatrix, int row, int column)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < theMatrix.GetLength(0); i++)
            {
                if (row + dirX[i] >= theMatrix.GetLength(0) || row + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }
                if (column + dirY[i] >= theMatrix.GetLength(0) || column + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }
            for (int i = 0; i < theMatrix.GetLength(0); i++)
                if (theMatrix[row + dirX[i], column + dirY[i]] == 0)
                {
                    return true;
                }

            return false;
        }

        static void find_cell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)

                for (int j = 0; j < arr.GetLength(0); j++)
                    if (arr[i, j] == 0) { x = i; y = j; return; }

        }

        static void Main()
        {
            Console.WriteLine("Enter a number between 1 and 100");
            string input = Console.ReadLine();
            int number;

            while (!int.TryParse(input, out number) || number < 0 || number > 100)
            {
                Console.WriteLine("You haven't entered a number between 1 and 100");
                input = Console.ReadLine();
            }
            
            int[,] matrix = new int[number, number];
            int step = number, k = 1, i = 0, j = 0, dx = 1, dy = 1;
            while (true)
            { //malko e kofti tova uslovie, no break-a raboti 100% : )
                matrix[i, j] = k;

                if (!proverka(matrix, i, j)) { break; } // prekusvame ako sme se zadunili
                if (i + dx >= number || i + dx < 0 || j + dy >= number || j + dy < 0 || matrix[i + dx, j + dy] != 0)


                    while ((i + dx >= number || i + dx < 0 || j + dy >= number || j + dy < 0 || matrix[i + dx, j + dy] != 0)) { change(ref dx, ref dy); }
                i += dx; j += dy; k++;
            }
            for (int p = 0; p < number; p++)
            {
                for (int q = 0; q < number; q++) Console.Write("{0,3}", matrix[p, q]);
                Console.WriteLine();
            }
            find_cell(matrix, out i, out j);
            if (i != 0 && j != 0)
            { // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
                dx = 1; dy = 1;


                while (true)
                { //malko e kofti tova uslovie, no break-a raboti 100% : )
                    matrix[i, j] = k;
                    if (!proverka(matrix, i, j)) { break; }// prekusvame ako sme se zadunili
                    if (i + dx >= number || i + dx < 0 || j + dy >= number || j + dy < 0 || matrix[i + dx, j + dy] != 0)


                        while ((i + dx >= number || i + dx < 0 || j + dy >= number || j + dy < 0 || matrix[i + dx, j + dy] != 0)) change(ref dx, ref dy);
                    i += dx; j += dy; k++;
                }
            }
            for (int pp = 0; pp < number; pp++)
            {
                for (int qq = 0; qq < number; qq++) Console.Write("{0,3}", matrix[pp, qq]);

                Console.WriteLine();
            }
        }
    }
}
