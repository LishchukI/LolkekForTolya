using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_1_2_Polimorfism
{
    //Приют для животных
     class AnimalShelter
    {
        //Constructors
        public AnimalShelter() { }
        public AnimalShelter(Animal animal)
        {
            AddAnimal(animal);
        }

        //Fields
        private List<Animal> _listOfAnimals = new List<Animal>();

        //Properties
        public int NumberOfAnimals { get; private set; } = 0;

        //Methods
        public void AddAnimal(Animal animal)
        {
            _listOfAnimals.Add(animal);
            NumberOfAnimals++;
        }

        public void RemoveAnimal(Animal animal)
        {
            _listOfAnimals.Remove(animal);
            NumberOfAnimals--;
        }

        public void GetAnimal(Animal animal)
        {
            _listOfAnimals.Find(animals => animals == animal).GetFullInformation();
            Console.WriteLine(nameof(animal));
        }
        public void AllAnimals()
        {
            Console.WriteLine();
            foreach (Animal animals in _listOfAnimals)
            {
                Console.Write(animals.Name + " ");
            }
            Console.WriteLine();
        }

        public void GetAllNameGottenAnimal<T> ()
        {
            var types = new Dictionary<Type, string>
            {
                { typeof(Kitty), "Котенок" },
                { typeof(Cat), "Кот" },
                { typeof(Dog), "Собака" },
            };

            Console.WriteLine();
            foreach (Animal animals in _listOfAnimals)
            {
                if (animals is T)
                {
                    if(animals.Name == "unnamed")
                        Console.Write($"ВНИМАНИЕ!!! {types[typeof(T)]} без имени!");
                    else
                        Console.WriteLine(animals.Name);
                }
            }
            Console.WriteLine();
        }
    }
}