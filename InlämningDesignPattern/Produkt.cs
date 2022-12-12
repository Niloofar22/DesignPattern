using System;
namespace InlämningDesignPattern
{
    public interface Produkt
    {
        string Info();
        // om du vill tillbaka resten av pengar 
        int Buy();
        // om man köper det kommer komentar
        string Use();

       
    }
}
