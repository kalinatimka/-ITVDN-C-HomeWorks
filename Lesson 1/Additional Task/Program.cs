using System;

//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
// класс с именем Address.
//В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого поля, создать свойство с двумя методами доступа.
//Создать экземпляр класса Address.
//В поля экземпляра записать информацию о почтовом адресе.  
//Выведите на экран значения полей, описывающих адрес. 

namespace Additional_Task
{   
    class Address
    {
        private string _index;
        public string Index
        {
            set { _index = value; }
            get { return _index; }
        }

        private string _country;
        public string Country
        {
            set { _country = value; }
            get { return _country; }
        }

        private string _city;
        public string City
        {
            set { _city = value; }
            get { return _city; }
        }

        private string _street;
        public string Street
        {
            set { _street = value; }
            get { return _street; }
        }

        private string _house;
        public string House
        {
            set { _house = value; }
            get { return _house; }
        }

        private string _apartment;
        public string Apartment
        {
            set { _apartment = value; }
            get { return _apartment; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address alexOlejnik = new Address();

            alexOlejnik.Index = "313234";
            alexOlejnik.Country = "Ukraine";
            alexOlejnik.City = "Kharkov";
            alexOlejnik.Street = "Tarasovskaya str.";
            alexOlejnik.House = "3";
            alexOlejnik.Apartment = "108";

            Console.WriteLine("Address of {0}:", nameof(alexOlejnik));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Index: {0}", alexOlejnik.Index);
            Console.WriteLine("Country: {0}", alexOlejnik.Country);
            Console.WriteLine("City: {0}", alexOlejnik.City);
            Console.WriteLine("Street: {0}", alexOlejnik.Street);
            Console.WriteLine("House: {0}", alexOlejnik.House);
            Console.WriteLine("Apartment: {0}", alexOlejnik.Apartment);

            //Delay
            Console.ReadKey();
        }
    }
}
