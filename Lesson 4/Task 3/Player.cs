using System;

//Задание 3 
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop()
//и void Record() / void Pause() / void Stop() соответственно. 
//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
//Написать программу, которая выполняет проигрывание и запись.

namespace Task_3
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Play()");
        }

        public void Record()
        {
            Console.WriteLine("Record()");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("IPlayable.Pause()");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("IPlayable.Stop()");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("IRecordable.Pause()");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("IRecordable.Stop()");
        }
    }

}
