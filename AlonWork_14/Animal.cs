using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_14
{
    abstract class Animal
    {
        public abstract string Name{get; set;}

        public Animal(string name)
        {
            Name = name;    
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }

    class Cat:Animal
    {
        string name;
        string voice;

        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Cat (string name/*, string voice*/)
            :base (name)
        {
            this.voice = /*voice=*/"Мяу";
        }
        public override void Say()
        {
            Console.WriteLine(voice);
        }
    }

    class Dog : Animal
    {
        string name;
        string voice;

        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name/*, string voice*/)
            : base(name)
        {
            this.voice = /*voice=*/"Гав";
        }
        public override void Say()
        {
            Console.WriteLine(voice);
        }
    }
}
