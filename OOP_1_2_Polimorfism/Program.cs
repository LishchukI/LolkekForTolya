using System;

namespace OOP_1_2_Polimorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat_first = new Cat(-3);
            Animal cat_second = new Cat("Васька");
            Animal cat_third = new Cat();

            Console.WriteLine("\n---------------Тест котов---------------\n");
            cat_first.GetFullInformation();
            cat_first.ActivationOfClaws();
            cat_first.LengthOfClaws = 6;
            cat_first.GetFullInformation();

            cat_second.Voice = "mmmmao";
            cat_second.ActivationOfClaws();
            cat_second.ActivationOfClaws();
            cat_second.LengthOfClaws = 4;
            cat_second.GetFullInformation();
            Console.WriteLine(cat_second.ToString());
            Console.WriteLine(cat_second.Equals(cat_first));
            Console.WriteLine(cat_second.Equals(cat_second));

            cat_third.GetFullInformation();


            Console.WriteLine("\n---------------Тест приюта---------------\n");
            AnimalShelter shelter_first = new AnimalShelter();
            shelter_first.AddAnimal(cat_first);
            shelter_first.AllAnimals();
            Console.WriteLine(shelter_first.NumberOfAnimals);
            shelter_first.AddAnimal(cat_second);
            shelter_first.AllAnimals();
            Console.WriteLine(shelter_first.NumberOfAnimals);

            shelter_first.GetAnimal(cat_second);
            cat_second.ActivationOfClaws();

            cat_second.LengthOfClaws = 5;
            cat_first.ActivationOfClaws();
            cat_first.Name = "Петька";
            shelter_first.AllAnimals();

            shelter_first.GetAnimal(cat_first);
            shelter_first.GetAnimal(cat_second);

            shelter_first.RemoveAnimal(cat_second);
            Console.WriteLine(shelter_first.NumberOfAnimals);
            shelter_first.AllAnimals();


            Console.WriteLine("\n---------------Тест котенка---------------\n");
            Kitty kitty_first = new Kitty(2);
            Console.WriteLine(kitty_first.Month);
            kitty_first.GetFullInformation();
            ((Cat)kitty_first).GetFullInformation();
            kitty_first.GetFullInformation();
            kitty_first.Name = "Муська";
            Console.WriteLine(kitty_first.ToString());

            shelter_first.AddAnimal(kitty_first);
            shelter_first.AllAnimals();
            Console.WriteLine(shelter_first.NumberOfAnimals);
            kitty_first.ActivationOfClaws();
            shelter_first.GetAnimal(kitty_first);

            Console.WriteLine("\n---------------Тест GetAllNameCats---------------\n");
            Kitty kitty_second = new Kitty(3, "Барсик");
            Kitty kitty_third = new Kitty();
            Dog dog_first = new Dog(2, "Шарик", "gggyyyav");
            Dog dog_second = new Dog(5, "Бобик");

            dog_first.GetFullInformation();
            shelter_first.AddAnimal(kitty_second);
            shelter_first.AddAnimal(kitty_third);
            shelter_first.AddAnimal(dog_first);
            shelter_first.AddAnimal(dog_second);
            shelter_first.AllAnimals();
            shelter_first.GetAllNameGottenAnimal<Cat>();
            shelter_first.GetAllNameGottenAnimal<Kitty>();
            shelter_first.GetAllNameGottenAnimal<Dog>();
        }
    }
}