using System;

namespace Module1
{
    class DrinksMachine
    {
        public string _location;
        public string _make;
        public string _model;

        public DrinksMachine()
        {
            _make = "Choose a make";
        }

        public void MakeCappuccino()
        {
            Console.WriteLine("Cappucino is ready!");
        }

        public void MakeEspresso()
        {
            Console.WriteLine("Espresso is ready!");
        }
    }
}