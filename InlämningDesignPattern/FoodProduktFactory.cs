using System;
namespace InlämningDesignPattern
{
    public class FoodProduktFactory : AbsFactory
    {
        public override Produkt GetProdukt(string ProduktType)
        {
            Console.WriteLine("Du kan välja mellan :");
            Console.WriteLine("1.Pasta");
            Console.WriteLine("2.Pizza");
            Console.WriteLine("3.Burger");
            Console.WriteLine();

            ProduktType = Console.ReadLine();
            if (ProduktType.Equals("2"))
            {
                return new Pizza();

            }
            else if (ProduktType.Equals("1"))
            {
                return new Pasta();
            }
            else if (ProduktType.Equals("3"))
            {
                return new Burger();
            }
            else
                return null;
        }
    }
}
