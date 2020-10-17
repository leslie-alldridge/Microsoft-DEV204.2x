using System;

namespace Module1
{
    class DrinksMachine
    {
        public DrinksMachine(string location, string make, string model)
        {
            this.Location = location;
            this.Make = make;
            this.Model = model;
        }
        private string _location;
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        private string _make;
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
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