using System;

//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать класс User, содержащий информацию о пользователе(логин, имя, фамилия, возраст, дата заполнения анкеты). 
//Поле дата заполнения анкеты должно быть проинициализировано только один раз(при создании экземпляра данного класса)
//без возможности его дальнейшего изменения. Реализуйте вывод на экран информации о пользователе.

namespace Additional_Task
{
    class User
    {
        private string login;
        private readonly string date;

        public string Login {
            set
            {
                if (value != null)
                    login = value;
            }

            private get { return login; }
        }
        public string FirstName { set; private get; }
        public string LastName { set; private get; }
        public string Age { set; private get; }

        public User(DateTime date)
        {
            this.date = date.ToString();
        }

        public void Show()
        {
            Console.WriteLine(new string('-',50));
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Login: {0} | Name: {1} {2} ", Login, FirstName, LastName);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine(new string('-', 50));
        }
    }
}
