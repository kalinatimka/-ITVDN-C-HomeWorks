using System;

//Задание 3 
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать класс Vehicle.
//В теле класса создайте поля:  координаты и параметры средств передвижения (цена, скорость, год выпуска).  
//Создайте 3 производных класса Plane, Саг и Ship.
//Для класса Plane должна быть определена высота и количество пассажиров.  
//Для класса Ship — количество пассажиров и порт приписки.
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane ship = new Plane();
            ship.x = 54.2434535;
            ship.y = 32.3243456;
            ship.speed = 43;
            ship.altitude = 10000;
            ship.price = 100000000;
            ship.issue = 1976;
            ship.passengers = 2500;

            ship.Show();
            Console.ReadKey();
        }
    }
}
