using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1_2_Polimorfism
{
    class Kitty : Cat
    {
        //Constructors
        public Kitty(int month = 0, string name = "unnamed", string voice = "...", int lenghtOfClaws = 0)
        {
            this.month = month;
            Name = name;
            Voice = voice;
            claws.LengthOfClaws = lenghtOfClaws;
        }

        //Fields
        protected int month;

        //Properties
        public int Month
        {
            get => month;
            set
            {
                if (value < 0)
                    Console.WriteLine("Error! (Возраст маленькой < 0)");
                else
                    month = value;
            }
        }

        //Methods
        public override void GetFullInformation()
        {
            Console.Write("\nID - " + id + ", ");
            Console.Write("возраст - " + month + " месяцев, ");
            Console.Write("имя - " + Name + ", ");
            Console.Write("голос - " + Voice + ", ");
            Console.Write("длина коготков - " + claws.LengthOfClaws + ", ");
            Console.Write("а коготки спрятаны?)0 - " + claws.GetInformationAboutClaws() + ".\n");
        }

        public override string ToString() =>
            $"\nID - {id}, возраст - {month} месяцев, имя - {Name}, голос - {Voice}, длина коготков - {claws.LengthOfClaws}, а коготки спрятаны?)0 - {claws.GetInformationAboutClaws()}.\n";
    }
}