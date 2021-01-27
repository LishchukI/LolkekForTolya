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