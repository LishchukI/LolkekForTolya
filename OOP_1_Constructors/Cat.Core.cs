﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1_2_Polimorfism
{
    partial class Cat
    {        
        //Constructors
        public Cat() { }
        public Cat(int age)
            : base(age, "unnamed", "maaaaaomav") { }
        public Cat(string name)
            : base(0, name, "myaauu", 2) { }
        public Cat(int age = 0, string name = "unnamed", string voice = "...", int lenghtOfClaws = 0)
            : base(age, name, voice, lenghtOfClaws) { }
    }
}