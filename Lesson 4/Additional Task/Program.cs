using System;

//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Изменить 12 пример первого урока(работа с документом) и создать общий абстрактный класс для всех частей документа

namespace Classes
{
    class Program
    {
        static void Main()
        {           
            Document document = new Document("Контракт");
            document.Body = "Тело контракта...";
            document.Footer = "Директор: Иванов И.И.";

            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
