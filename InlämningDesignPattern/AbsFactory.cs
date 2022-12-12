using System;
namespace InlämningDesignPattern
{
    public abstract class AbsFactory
    {
        public abstract Produkt GetProdukt(string ProduktType);

        public static AbsFactory CreateAbsFactory(string ProduktType)
        {
            Console.WriteLine("Hej och välkommen Kära kund ");
            Console.WriteLine("Välja mellan :");
            Console.WriteLine("1.Clothes");
            Console.WriteLine("2.Food");
            Console.WriteLine("3.Liquid");
            Console.WriteLine();
            ProduktType = Console.ReadLine();

            if ( ProduktType.Equals("1"))
                return new ClothsProductFactory();
            
            else if (ProduktType.Equals("2"))
                return new FoodProduktFactory();
            else
                return new LiquidProduktFactory();


              

        }
      

    }
   
}
