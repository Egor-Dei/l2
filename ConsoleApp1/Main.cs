using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Properties;


namespace ConsoleApp1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            int n = 5;
            IAnimal [] animals = new IAnimal[n];
            animals[1] = new Bird();
            animals[0] = new Penguin();
            animals[2] = new Fish();
            animals[3] = new Mammal();
            animals[4] = new Dolphin();
            for (int i = 0; i < n; i++)
            {
                animals[i].ToString();
            }
            Console.ReadKey();
        }
    }
}
