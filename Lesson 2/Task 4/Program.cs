using System;

//Задание 4 
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать класс Invoice.
//В теле класса создать три поля int account, string customer, string provider которые должны быть проинициализированы один раз 
//(при создании экземпляра данного класса) без возможности их дальнейшего изменения.
//В теле класса создать два закрытых поля string article, int quantity
//Создать метод расчета стоимости заказа с НДС и без НДС.
//Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 100;

            Invoice invoice1 = new Invoice(255, "ООО ХАДО-технология", "ООО Шняга");
            Console.WriteLine("Артикул: {0}; Количество: {1}; Цена: {2}; Сумма: {3}", invoice1.Article = "Батарея", invoice1.Quantity = 10, price, invoice1.GetSum(true, 100));

            //Delay
            Console.ReadKey();
        }
    }
}
