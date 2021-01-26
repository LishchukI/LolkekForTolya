namespace OOP_1_2_Polimorfism
{
    partial class Dog : Animal
    {
        public sealed override void ActivationOfClaws() //Запечатан по фану)0
        {
            base.ActivationOfClaws();
        }
    }
}