using System;

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
    class ClassRoom
    {
        Pupil[] classRoom = null;
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            classRoom = new Pupil[4] {new Pupil(), new Pupil(), pupil1, pupil2 };
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            classRoom = new Pupil[4] { new Pupil(), pupil1, pupil2, pupil3 };
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            classRoom = new Pupil[4] { pupil1, pupil2, pupil3, pupil4};
        }

        public void Show()
        {
            for (int i = 0; i < 4; i++)
            {
                classRoom[i].Show();
            }
        }
    }
}
