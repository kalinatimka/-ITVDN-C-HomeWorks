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
    class Vehicle
    {
        public double x, y, speed;
        public decimal price;
        public int issue;
   
        public void Show()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Coordinates: X = {0:##.###}, Y = {1:##.###}", x, y);
            Console.WriteLine("Price: {0:C}; MaxSpeed: {1}; Issue: {2}", price, speed, issue);  
        }
    }

    class Plane : Vehicle
    {
        public double altitude;
        public int passengers;
        
        public new void Show()
        {
            base.Show();
            Console.WriteLine("Max flying altitude: {0}; Number of passengers: {1}", altitude, passengers);
        }
    }

    class Car : Vehicle
    {
        public new void Show()
        {
            base.Show();
        }
    }

    class Ship : Vehicle
    {
        public string port;
        public int passengers;

        public new void Show()
        {
            base.Show();
            Console.WriteLine("Home port: {0}; Number of passengers: {1}", port, passengers);
        }
    }
}
