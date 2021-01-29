namespace OOP_1_2_Polimorfism
{
    //Коготки
    class Claws
    {
        //Fields
        private bool _statusOfClaws = false;

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
            _statusOfClaws = !_statusOfClaws;
        }
    }
}