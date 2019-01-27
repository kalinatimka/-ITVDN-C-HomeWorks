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
    class Program
    {
        static void Main(string[] args)
        {
            Employee teacher = new Employee("Вика", "Ренкус");
            teacher.GetSalary("Учитель", 3);

            Employee headteacher = new Employee("Ольга", "Бырька");
            headteacher.GetSalary("завуч", 5);

            Employee principal = new Employee("Людмила", "Гамивка");
            principal.GetSalary("Директор", 25);

            //Delay
            Console.ReadKey();
        }
    }
}
