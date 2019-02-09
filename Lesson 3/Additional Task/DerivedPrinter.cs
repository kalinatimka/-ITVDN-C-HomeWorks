﻿using System;

//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создайте класс Printer.
//В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
//Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, 
//и вызове соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов, выводились разными цветами.
//Обязательно используйте приведение типов. 

namespace Additional_Task
{
    class DerivedPrinter : BasePrinter
    {
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.Print(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
