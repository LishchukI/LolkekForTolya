using System;

namespace OOP_1_2_Polimorfism
{
    //Приют для животных
    partial class AnimalShelter
    {
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
            foreach (Animal animals in _listOfAnimals)
            {
                if (animals == animal)
                {
                    animals.GetFullInformation();
                    break;
                }
            }
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
            Console.WriteLine();
            foreach (Animal animals in _listOfAnimals)
            {
                if (animals is T)
                {
                    if (animals.Name == "unnamed")
                    {
                        switch (animals)
                        {
                            case Kitty _:
                                Console.Write("ВНИМАНИЕ!!! Котенок без имени! - ");
                                break;
                            case Cat _:
                                Console.Write("ВНИМАНИЕ!!! Кот без имени! - ");
                                break;
                            case Dog _:
                                Console.Write("ВНИМАНИЕ!!! Собака без имени! - ");
                                break;
                        }
                    }
                    Console.WriteLine(animals.Name);
                }
            }
            Console.WriteLine();
        }
    }
}