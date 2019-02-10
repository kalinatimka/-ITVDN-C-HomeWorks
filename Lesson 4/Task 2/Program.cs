using System;

//Задание 2 
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создайте класс AbstractHandler.
//В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
//Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
//Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, 
//редактирования, сохранения определенного формата документа.  

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler FileChoosing(string fileName)
            {
                AbstractHandler handler = null;
                if (fileName.Length <= 4)
                {
                    Console.WriteLine("Слишком короткое имя файла");
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine();
                    return null;
                }
                string format = fileName.Substring(fileName.Length - 4);
                switch (format.ToLower())
                {
                    case ".doc":
                        handler = new DOCHandler(fileName);
                        break;
                    case ".txt":
                        handler = new TXTHandler(fileName);
                        break;
                    case ".xml":
                        handler = new XMLHandler(fileName);
                        break;
                    default:
                        Console.WriteLine("Не поддерживаемое расширение");
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine();
                        return null;
                }
                if (handler != null)
                {
                    handler.Create();
                    handler.Change();
                    handler.Save();
                    handler.Open();
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine();
                }
                return handler;
            }

            
            FileChoosing("readme.doc");
            FileChoosing("TX");
            FileChoosing("index.xml");
            FileChoosing("1.TXb");
            FileChoosing("sddggfg.doc");

            //Delay
            Console.ReadKey();
        }
    }
}