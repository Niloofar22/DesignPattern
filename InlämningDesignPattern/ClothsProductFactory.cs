using System;
namespace InlämningDesignPattern
{
    public class ClothsProductFactory : AbsFactory
    {
        public override Produkt GetProdukt(string ProduktType)
        {
            Console.WriteLine("Du kan välja mellan :");
            Console.WriteLine("1.Hot");
            Console.WriteLine("2.Jacket");
            Console.WriteLine("3.Coat");
            Console.WriteLine();
            ProduktType = Console.ReadLine();
            if (ProduktType.Equals("1"))
            {
                return new Hot();

            }
            else if (ProduktType.Equals("2"))
            {
                return new Jacket();
            }
            else if (ProduktType.Equals("3"))
            {
                return new Coat();
            }
            else
                return null;
        }
    }
}
