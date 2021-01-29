using System;

namespace OOP_1_2_Polimorfism
{
    abstract class Animal
    {
        //Constructors
        public Animal(string name)
            : this(0, name) { }
        public Animal(int age = 0, string name = "unnamed", string voice = "...", int lenghtOfClaws = 0)
        {
            ID = id;
            Age = age;
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

        //Properties
        public int ID
        {
            get => id;
            protected set => id = staticId++;
        }
        public string Name { get; set; }
        public string Voice { get; set; }
        public int Age
        {
            get => age;
            set
            {
                AgeOfAnimalException ex = new AgeOfAnimalException("Age error! Age has been changed to standard '0'.", "Age must be greater than 0!", DateTime.Now);
                try
                {
                    if (value < 0)
                    {
                        throw ex;
                    }
                    else
                        age = value;
                }
                catch (AgeOfAnimalException e)
                {
                    Console.WriteLine("Member name: " + e.TargetSite);
                    Console.WriteLine("Message: " + e.Message);
                    Console.WriteLine("Time of error: " + e.ErrorTime);
                    Console.WriteLine("Cause: " + e.CauseOfError);
                }
             }
        }
        public int LengthOfClaws
        {
            get => claws.LengthOfClaws;
            set => claws.LengthOfClaws = value;
        }

        //Mehods
        public virtual void GetFullInformation()
        {
            Console.Write("Возраст - " + age + " лет, ");
            Console.Write("имя - " + Name + ", ");
            Console.Write("голос - " + Voice + ", ");
            Console.Write("длина коготков - " + claws.LengthOfClaws + ", ");
            Console.Write("а коготки спрятаны?)0 - " + claws.GetInformationAboutClaws() + ".\n");
        }

        public virtual void ActivationOfClaws()
        {
            claws.ActivationOfClaws();
        }

        public override string ToString() =>
            $"\nВозраст - {age} лет, имя - {Name}, голос - {Voice}, длина коготков - {claws.LengthOfClaws}, а коготки спрятаны?)0 - {claws.GetInformationAboutClaws()}.\n";
        public override bool Equals(object obj) =>
            obj?.ToString() == ToString();
        public override int GetHashCode() => 
            id.GetHashCode();
    }
}