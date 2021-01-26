using System;
using System.Collections.Generic;

namespace OOP_1_2_Polimorfism
{
    partial class AnimalShelter
    {
        //Constructors
        public AnimalShelter() { }
        public AnimalShelter(Animal animal)
        {
            AddAnimal(animal);
        }

        //Fields
        private List<Animal> _listOfAnimals = new List<Animal>();
    }
}