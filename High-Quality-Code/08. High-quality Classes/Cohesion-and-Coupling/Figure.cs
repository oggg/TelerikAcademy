namespace CohesionAndCoupling
{
    public class Figure
    {
        private double width;
        private double height;
        private double depth;

        public Figure(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                Utility.SizeCheck(value);
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                Utility.SizeCheck(value);
                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }
            set
            {
                Utility.SizeCheck(value);
                this.depth = value;
            }
        }
        
        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }
    }
}
