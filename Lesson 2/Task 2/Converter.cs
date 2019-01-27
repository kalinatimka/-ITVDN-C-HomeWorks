using System;

//Задание 2 
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать класс Converter.
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне - public Converter(double usd, double eur, double rub).  
//Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, также программа должна производить конвертацию из указанных валют в гривну.

namespace Task_2
{
    class Converter
    {
        private double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public void ToUanConverter(string value, double sum)
        {
            double result = 0;
            if (value == "usd")
                result = sum * usd;
            if (value == "eur")
                result = sum * eur;
            if (value == "rub")
                result = sum * rub;
            Console.WriteLine("{0:#.##} {1} = {2:#.##} uan",sum, value, result);
        }
        public void FromUanConverter(string value, double sum)
        {
            double result = 0;
            if (value == "usd")
                result = sum / usd;
            if (value == "eur")
                result = sum / eur;
            if (value == "rub")
                result = sum / rub;
            Console.WriteLine("{0:#.##} uan = {1:#.##} {2}", sum, result, value);
        }
    }
}
