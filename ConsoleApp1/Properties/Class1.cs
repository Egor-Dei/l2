using System;
namespace ConsoleApp1.Properties
{
    /*public class Animal
    {
        public virtual int Live (bool islive)
        {
            return 1;
        }
        
    }

   public class Bird : Animal
    {
        string Name { get; set; }
        public Bird(string name) : base()
        {
            Name = name;
        }

        public override int Live(bool islive)
        {
            islive = true;
            return 3;
        }
    }*/

    public interface IAnimal
    {
        void ToString();
    }

    public class Bird : IAnimal
    {
        public virtual void ToString()
        {
            Console.WriteLine("Я птица, я умею летать!");
        }
        
    }

    public class Penguin : Bird
    {

        public override void ToString()
        {
            Console.WriteLine("Я пингвин. Да, я птица, но не летаю. Ну и пофиг! Я плаваююю!");
        }
       
    }
    public class Fish : IAnimal
    {
        public virtual void ToString()
        {
            Console.WriteLine("Я рыба, я умею плавать!");
        }
    }
    public class Mammal : IAnimal
    {
        public virtual void ToString()
        {
            Console.WriteLine("Я млекопитающее!");
        }
    }
    public class Dolphin : Mammal
    {

        public override void ToString()
        {
            Console.WriteLine("Я дельфин. Может, я и плаваю, как рыба, но я млекопитающее!");
        }

    }
}
