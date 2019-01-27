using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(28.17, 32.1, 0.43);

            converter.FromUanConverter("eur", 100);
            converter.FromUanConverter("usd", 100);
            converter.FromUanConverter("rub", 100);
            Console.WriteLine(new string('-', 25));
            converter.ToUanConverter("eur", 100);
            converter.ToUanConverter("usd", 100);
            converter.ToUanConverter("rub", 100);
            //Delay
            Console.ReadKey();
        }
    }
}
