using System;
namespace InlämningDesignPattern
{
    public class Water : Produkt
    {
        public int Buy()
        {
            return 20;
            
        }

        public string Info()
        {
            return "Still mineralwatten";
        }

        public string Use()
        {
            return "Dryck Kall watten";
        }
    }
}

