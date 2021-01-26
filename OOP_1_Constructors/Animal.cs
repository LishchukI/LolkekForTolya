using System;

namespace OOP_1_2_Polimorfism
{
    abstract partial class Animal
    {
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
                if (value < 0)
                    Console.WriteLine("Error! (Возраст < 0)");
                else
                    age = value;
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
            Console.Write("\nID - " + id + ", ");
            Console.Write("возраст - " + age + " лет, ");
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
            $"\nID - {id}, возраст - {age} лет, имя - {Name}, голос - {Voice}, длина коготков - {claws.LengthOfClaws}, а коготки спрятаны?)0 - {claws.GetInformationAboutClaws()}.\n";

        public override bool Equals(object obj) =>
            obj?.ToString() == ToString();

        public override int GetHashCode() => 
            id.GetHashCode();
    }
}