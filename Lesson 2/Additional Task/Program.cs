using System;

//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать класс User, содержащий информацию о пользователе(логин, имя, фамилия, возраст, дата заполнения анкеты). 
//Поле дата заполнения анкеты должно быть проинициализировано только один раз(при создании экземпляра данного класса)
//без возможности его дальнейшего изменения. Реализуйте вывод на экран информации о пользователе.

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            User loh = new User(DateTime.Now)
            {
                Login = "KN90PA",
                FirstName = "Artem",
                LastName = "Sidora",
                Age = "30"
            };

            loh.Show();

            //Delay
            Console.ReadKey();
        }
    }
}
