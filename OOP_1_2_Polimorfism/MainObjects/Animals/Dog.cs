namespace OOP_1_2_Polimorfism
{
    class Dog : Animal
    {
        //Constructors
        public Dog() { }
        public Dog(string name)
            : base(name) { }
        public Dog(int age, string name)
            : base(age, name, "gavgav") { }
        public Dog(int age = 0, string name = "unnamed", string voice = "...", int lenghtOfClaws = 0)
            : base(age, name, voice, lenghtOfClaws) { }

        public sealed override void ActivationOfClaws() //Запечатан по фану)0
        {
            base.ActivationOfClaws();
        }
    }
}