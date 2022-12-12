using System;
namespace InlämningDesignPattern
{
    public class Burger : Produkt
    {
        public int Buy()
        {
            return 100;
        }

        public string Info()
        {
            return "Stor bergur med olika sås";
        }

        public string Use()
        {
            return "ät upp Smaklig Måltid";
        }
    }
}
