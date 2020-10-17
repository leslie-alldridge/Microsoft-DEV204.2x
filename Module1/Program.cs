using System;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine MyMachine = new DrinksMachine("Kitchen", "Nespresso", "DM-1000");
            Console.WriteLine(MyMachine.Make);
            Console.WriteLine(MyMachine.Model);
            Console.WriteLine(MyMachine.Location);
            // Make Drinks
            MyMachine.MakeCappuccino();
            MyMachine.MakeEspresso();
        }
    }
}
