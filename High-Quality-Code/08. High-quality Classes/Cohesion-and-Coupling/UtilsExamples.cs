using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(File.GetExtension("example"));
            Console.WriteLine(File.GetExtension("example.pdf"));
            Console.WriteLine(File.GetExtension("example.new.pdf"));

            Console.WriteLine(File.GetName("example"));
            Console.WriteLine(File.GetName("example.pdf"));
            Console.WriteLine(File.GetName("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Geometry.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Geometry.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Figure figure3D = new Figure(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", figure3D.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Geometry.CalcDiagonal3D(figure3D.Width, figure3D.Height, figure3D.Depth));
            Console.WriteLine("Diagonal XY = {0:f2}", Geometry.CalcDiagonal2D(figure3D.Width, figure3D.Height));
            Console.WriteLine("Diagonal XZ = {0:f2}", Geometry.CalcDiagonal2D(figure3D.Width, figure3D.Depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", Geometry.CalcDiagonal2D(figure3D.Height, figure3D.Depth));
        }
    }
}
