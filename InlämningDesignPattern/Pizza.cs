using System;
namespace InlämningDesignPattern
{
    public class Pizza : Produkt
    {
        public int Buy()
        {
            return 120;
        }

        public string Info()
        {
            return " Pizza Margherita ";
        }

        public string Use()
        {
            return "Smaklig måltid";
        }
    }
}
