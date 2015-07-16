using System;

namespace ClassSize
{
    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public static Size GetRotatedSize(Size size, double angleOfFigureRotation)
        {
            double sinus = Math.Abs(Math.Cos(angleOfFigureRotation));
            double cosinus = Math.Abs(Math.Cos(angleOfFigureRotation));
            double rotatedWidth = cosinus * size.width + sinus * size.height;
            double rotatedHeight = sinus * size.width + cosinus * size.height;

            Size rotatedFigure = new Size(rotatedWidth, rotatedHeight);

            return rotatedFigure;
        }
    }
}
