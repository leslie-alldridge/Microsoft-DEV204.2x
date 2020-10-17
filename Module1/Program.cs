using System;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine MyMachine = new DrinksMachine();
            MyMachine._location = "Kitchen";
            MyMachine._model = "DM-1000";
            Console.WriteLine(MyMachine._make);

            // Make Drinks
            MyMachine.MakeCappuccino();
            MyMachine.MakeEspresso();
        }
    }
}
