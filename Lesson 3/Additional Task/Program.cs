using System;

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
    class Program
    {
        static void Main(string[] args)
        {
            DerivedPrinter derivedPrinter = new DerivedPrinter();
            derivedPrinter.Print("12345");

            BasePrinter basePrinter = new BasePrinter();
            basePrinter.Print("56789");

            basePrinter = derivedPrinter;
            basePrinter.Print("1234567890");

            derivedPrinter = (DerivedPrinter)basePrinter;
            derivedPrinter.Print("0000");

            //Delay
            Console.ReadKey();
        }
    }
}
