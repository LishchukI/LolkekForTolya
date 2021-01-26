using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1_2_Polimorfism
{
    partial class Kitty
    {
        //Constructors
        public Kitty (int month = 0, string name = "unnamed", string voice = "...", int lenghtOfClaws = 0)
        {
            this.month = month;
            Name = name;
            Voice = voice;
            claws.LengthOfClaws = lenghtOfClaws;
        }

        //Fields
        protected int month;
    }
}