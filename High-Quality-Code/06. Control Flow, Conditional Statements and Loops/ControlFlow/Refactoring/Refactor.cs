using System;

namespace Refactoring
{
    class Refactor
    {
        static void Main()
        {



            //Potato potato;
            ////... 
            //if (potato != null)
            //    if (!potato.HasNotBeenPeeled && !potato.IsRotten)
            //        Cook(potato);

            Potato potato;
            // ....
            if (potato != null)
            {
                bool notPeerled = !potato.IsPeeled;
                bool notRotten = !potato.IsRotten;

                if (notPeerled && notRotten)
                {
                    potato.Cook();
                }
                    
            }

            //   if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            //   {
            //     VisitCell();
            //   }

            const int MIN_X = 1;
            const int MAX_X = 10;
            const int MIN_Y = 20;
            const int MAX_Y = 30;

            int x = 5;
            int y = 15;

            bool allowedCell = true;

            if (CheckRange(MIN_X, MAX_X, x) && CheckRange(MIN_Y, MAX_Y, y) && allowedCell)
            {
                VisitCell();
            }
        }

        static bool CheckRange(int min, int max, int value)
        {
            if (min < value && value < max)
            {
                return true;
            }
            return false;
        }
    }
}
