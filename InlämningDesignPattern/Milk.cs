using System;
namespace InlämningDesignPattern
{
    public class Milk : Produkt
    {
        public int Buy()
        {
            return 20;
        }

        public string Info()
        {
            return "Laktosfri Mjölk";
        }

        public string Use()
        {
            return "Dick laktosfri mjölk";
        }
    }
}
