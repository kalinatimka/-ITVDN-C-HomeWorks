﻿using System;

//Задание 2 
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать класс, представляющий учебный класс ClassRoom.  
//Создайте класс ученик Pupil.  В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().  
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый
//из методов, в зависимости от успеваемости ученика.
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.

namespace Task_2
{
    class GoodPupil : Pupil
    {
        protected override void Study()
        {
            Console.WriteLine("GoodPupil.Study()");
        }
        protected override void Read()
        {
            Console.WriteLine("GoodPupil.Read()");
        }
        protected override void Write()
        {
            Console.WriteLine("GoodPupil.Write()");
        }
        protected override void Relax()
        {
            Console.WriteLine("GoodPupil.Relax()");
        }
        public override void Show()
        {
            base.Show();
        }
    }
}
