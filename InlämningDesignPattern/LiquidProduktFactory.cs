using System;
namespace InlämningDesignPattern
{
    

    public class LiquidProduktFactory : AbsFactory
       
    {
       
        public override Produkt GetProdukt(string ProduktType)

            
        {
            Console.WriteLine("Du kan välja mellan :");
            Console.WriteLine("1.Milk");
            Console.WriteLine("2.Coffee");
            Console.WriteLine("3.Water");
            Console.WriteLine();
            ProduktType = Console.ReadLine();


            if (ProduktType.Equals("1"))
                
            {

                return new Milk();   

            }
            else if (ProduktType.Equals("2"))
            {
                return new Coffe();
            }
            else if (ProduktType.Equals("3"))
            {
                return new Water();
            }
            else
                return null;
        }
    }
}
