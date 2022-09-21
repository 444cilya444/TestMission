using System;

namespace TestMyLib
{
    internal interface IFigure
    {
        string Sides(double[] sides);
    }
    public class CircleSquare : IFigure
    {
        public string Sides(double[] sides)
        {
            return "Круг " + Math.Round(Math.PI * Math.Pow(sides[0], 2), 2);
        }
    }
    public class TriangleSquare : IFigure
    {
        double[] straightTriangle;
        public string Sides(double[] sides)
        {
            straightTriangle = sides;
            double p = (sides[0] + sides[1] + sides[2]) / 2;
            double square = Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
            return "Треугольник " + square;
        }
        public bool СorrectnessTriangle()
        {
            bool isStraight = (straightTriangle[0] == Math.Sqrt(Math.Pow(straightTriangle[1], 2) + Math.Pow(straightTriangle[2], 2))
                || straightTriangle[0] == Math.Sqrt(Math.Pow(straightTriangle[1], 2) + Math.Pow(straightTriangle[2], 2))
                || straightTriangle[0] == Math.Sqrt(Math.Pow(straightTriangle[1], 2) + Math.Pow(straightTriangle[2], 2)));
            return isStraight;
        }
        public string TriangleIsRectangular()
        {
            if (straightTriangle[0] < 0 || straightTriangle[1] < 0 || straightTriangle[2] < 0)
            {
                return "Такого треугольника не существует(сторона(ы) меньше 0)";
            }

            if (straightTriangle[0] > (straightTriangle[1] + straightTriangle[2]) || straightTriangle[1] > (straightTriangle[0] + straightTriangle[2]) || straightTriangle[2] > (straightTriangle[0] + straightTriangle[1]))
            {
                return "Такого треугольника не существует(сторона больше суммы двух других)";
            }
            return "Tреугольник существует";
        }
    }
}
