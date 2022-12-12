using System;
namespace InlämningDesignPattern
{
    public class Coat : Produkt
    {
        public int Buy()
        {

            return 400;
            
        }

        public string Info()
        {
            return "Nice Coat for you, Black, Ssize";
        }

        public string Use()
        {
            return "Ta på dig ";
        }
    }
}
