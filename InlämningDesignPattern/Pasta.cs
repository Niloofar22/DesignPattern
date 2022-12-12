using System;
namespace InlämningDesignPattern
{
    public class Pasta : Produkt
    {
        public int Buy()
        {
            return 90;
        }

        public string Info()
        {
            return "Pasta allAmatriciana";
        }

        public string Use()
        {
            return " ÄT farsk och god pasta";
        }
    }
}
