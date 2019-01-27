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
    class Invoice
    {
        private readonly int account;
        private readonly string customer, provider;
        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public string Article
        {
        
            set
            {
                if (value.Equals(string.Empty))
                    article = value;
            }

            get
            {
                if (article == null)
                    return "Товар не известен";
                return article;
            }
        }

        public int Quantity
        {
            set
            {
                if (value > 0)
                    quantity = value;
            }

            get { return quantity; }
        }

        public double GetSum(bool vat, double price)
        {
            if (vat)
                return Quantity * price * 0.8;
            return Quantity * price;
        }

    }
}
