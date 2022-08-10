using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    static class Circle
    {
        static public double CircleLength(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static public double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        static public string IsBelongs(double pointX, double pointY, double centerX, double centerY, double radius)
        {
            //Находим расстояние от центра окружности до точки и сравниваем с радиусом
            double distanceFromCenter = Math.Sqrt(Math.Pow((pointX - centerX), 2) + Math.Pow((pointY - centerY), 2));
            if (distanceFromCenter > radius)
            {
                return "Точка лежит за пределами окружности";
            }
            else if (distanceFromCenter < radius)
            {
                return "Точка лежит внутри окружности";
            }
            else
            {
                return "Точка лежит на окружности";
            }
        }
    }
}
