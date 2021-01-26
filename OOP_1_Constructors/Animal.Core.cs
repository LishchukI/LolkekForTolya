using System;

namespace OOP_1_2_Polimorfism
{
    partial class Animal
    {
        //Constructors
        public Animal(string name)
            : this(0, name) { }
        public Animal(int age = 0, string name = "unnamed", string voice = "...", int lenghtOfClaws = 0)
        {
            ID = id;
            this.age = age;
            Name = name;
            Voice = voice;
            claws.LengthOfClaws = lenghtOfClaws;
        }

        //Fields
        //Static
        public static int Paws { get; } = 4;

        //Non-static
        protected int age;
        static protected int staticId = 1;
        protected int id;
        protected Claws claws = new Claws();
    }
}