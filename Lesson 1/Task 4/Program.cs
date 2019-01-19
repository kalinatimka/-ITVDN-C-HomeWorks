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
    class Program
    {
        static void Main(string[] args)
        {
            Figure rectangle1 = new Figure(new Point("A", 0, 0), new Point("B", 5, 0), new Point("C", 5, 5), new Point("D", 0, 5));
            rectangle1.Show();

            Figure rectangle2 = new Figure(new Point("A", 0, 0), new Point("B", 5, 0), new Point("C", 5, 5), new Point("D", 0, 5), new Point("E",-5, 0));
            rectangle2.Show();
            //Delay
            Console.ReadKey();
        }
    }
}
