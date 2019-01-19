using System;

//Задание 4 
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать классы Point и Figure.
//Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.  
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
//Написать программу, которая выводит на экран название и периметр многоугольника.

namespace Task_4
{
    class Figure
    {
        Point[] points;
        string name;
        double perimeter = 0;

        public Figure(Point a, Point b, Point c)
        {
            name = "Triangle";
            points = new Point[3];
            points[0] = a;
            points[1] = b;
            points[2] = c;
        }
        public Figure(Point a, Point b, Point c, Point d)
        {
            name = "Tetragon";
            points = new Point[4];
            points[0] = a;
            points[1] = b;
            points[2] = c;
            points[3] = d;
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            name = "Pentagon";
            points = new Point[5];
            points[0] = a;
            points[1] = b;
            points[2] = c;
            points[3] = d;
            points[4] = e;
        }

        private double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
        }

        private void PerimeterCalculator()
        {
            for(int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]); 
            }
            perimeter += LengthSide(points[points.Length - 1], points[0]);
        }

        public void Show()
        {
            Console.WriteLine("Rectangle is {0}", name);
            PerimeterCalculator();
            Console.WriteLine("Perimeter = {0}", perimeter);
        }
    }
}
