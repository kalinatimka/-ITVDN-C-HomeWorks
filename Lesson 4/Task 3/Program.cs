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
    class Program
    {
        static void Main()
        {
            Player player = new Player();

            player.Play();
            (player as IPlayable).Stop();

            player.Record();
            (player as IRecordable).Stop();

            Console.ReadKey();
        }
    }
}
