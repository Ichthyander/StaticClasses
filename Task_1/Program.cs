using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.   Разработать статический класс для работы с окружностью. 
 * Класс должен содержать 3 метода:

метод, определяющий длину окружности по заданному радиусу;
метод, определяющий площадь круга по заданному радиусу;
метод, проверяющий принадлежность точки с координатами (x,y) кругу с 
радиусом r и координатами центра x0, y0.*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестирование программы");
            Console.WriteLine();

            //Значения для тестирования
            double radius_1 = 1;
            double centerX_1 = 0.5;
            double centerY_1 = 1;
            double pointX_1 = 2;
            double pointY_1 = 1;
            
            //Блок вывода
            Console.WriteLine("Длина окружности с радиусом {0} равняется - {1}", radius_1, Circle.CircleLength(radius_1));
            Console.WriteLine("Площадь окружности с радиусом {0} равняется - {1}", radius_1, Circle.CircleArea(radius_1));
            Console.WriteLine(Circle.IsBelongs(pointX_1, pointY_1, centerX_1, centerY_1, radius_1));
            Console.ReadKey();
        }
    }
}
