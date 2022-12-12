using System;
namespace InlämningDesignPattern
{
    public class Hot : Produkt
    {
        public int Buy()
        {
            return 200;
        }

       

        public string Info()
        {
            return " Stickade mössa i olika färger one size";
        }

        public string Use()
        {
            return " Mössa för kallt väder";
        }

       
    }
}
