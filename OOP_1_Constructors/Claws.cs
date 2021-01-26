namespace OOP_1_2_Polimorfism
{
    //Коготки
    partial class Claws
    {
        //Properties
        public int LengthOfClaws { get; set; }

        //Methods
        public string GetInformationAboutClaws()
        {
            if (_statusOfClaws)
                return ("Коготки активированы!");
            else
                return ("Коготки спрятаны...");
        }

        public void ActivationOfClaws()
        {
            if (_statusOfClaws)
                _statusOfClaws = false;
            else
                _statusOfClaws = true;
        }
    }
}