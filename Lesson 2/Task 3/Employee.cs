using System;

//Задание 3 
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: 
//Создать класс Employee.
//В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, 
//соответствующие фамилии и имени сотрудника.
//Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
//Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор.

namespace Task_3
{
    class Employee
    {
        private string firstName, lastName;
        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void GetSalary(string job, int expirience)
        {
            string[] jobs = new string[] { "учитель", "завуч", "директор" };
            double salary = 0, tax = 0, ratio = 1;



            if (job.ToLower().Equals(jobs[0]))
                salary = 7000;
            else if (job.ToLower().Equals(jobs[1]))
                salary = 10000;
            else if (job.ToLower().Equals(jobs[2]))
                salary = 15000;
            else
            {
                Console.WriteLine("<<Введите существующую должность>>");
                Console.WriteLine();
            }
            if (expirience > 0)
            {
                if (expirience > 0 && expirience < 3)
                    ratio = 0;
                if (expirience >= 3 && expirience < 5)
                    ratio = 0.1;
                if (expirience >= 5 && expirience < 10)
                    ratio = 0.2;
                if (expirience >= 10 && expirience < 15)
                    ratio = 0.3;
                if (expirience >= 15)
                    ratio = 0.4;
            }
            else
            {
                Console.WriteLine("<<Введите число больше 0>>");
                Console.WriteLine();
            }
            salary += salary * ratio;
            tax = salary * 0.18;

            Console.WriteLine("{1} {0}, {2}", firstName, lastName, job.ToUpper());
            Console.WriteLine("Оклад: {0}. Налоговый сбор: {1}.", salary, tax);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Итого: {0}", salary - tax);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
