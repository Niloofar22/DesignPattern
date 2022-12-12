using System;
namespace InlämningDesignPattern
{
    public class Coffe : Produkt
    {
        public int Buy()
        {
            return 30;
        }

        public string Info()
        {
            return " Koffeinfritt Kaffe";
        }

        public string Use()
        {
            return "Drick ditt Kaffe";
        }

       
    }
}
