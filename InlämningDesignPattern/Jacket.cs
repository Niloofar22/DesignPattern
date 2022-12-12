using System;
namespace InlämningDesignPattern
{
    public class Jacket : Produkt

    {
        public int Buy()
        {
            return 800;
        }

        public string Info()
        {
            return "Fina jackor i olika storlek";
        }

        public string Use()
        {
            return "Ta på dig i kallt väder";
        }
    }
}
