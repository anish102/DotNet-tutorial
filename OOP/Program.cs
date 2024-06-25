using System;

namespace OOP
{
    class Animal
    {

        public string name;
        public Animal()
        {
            name = "Dog";
        }

        public virtual void speak()
        {
            Console.WriteLine("Barks........");
        }
    }

    class Cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Meow.......");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            myCat.speak();
        }
    }
}