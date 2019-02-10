﻿using System;

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
    abstract class AbstractHandler
    {
        public string fileName;
        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        public void Change()
        {
            Console.WriteLine(fileName + " изменен");
        }

        public void Create()
        {
            Console.WriteLine(fileName + " создан");
        }

        public void Open()
        {
            Console.WriteLine(fileName + " открыт");
        }
        public abstract void Save();
    }
}
