using System;

namespace InlämningDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkt produkt = null;
            AbsFactory absFactory = null;
            String Description = null;
            
            int Price;
            string N;
            string Använd = null;
            string Y;
            String S;
            int Pro;

           


          igen:
            absFactory = AbsFactory.CreateAbsFactory(" ");
            
            /*Console.WriteLine("type Produkt :" + absFactory.GetType().Name);*/


            produkt = absFactory.GetProdukt(" ");
            Console.WriteLine("PRODUK TYP :" + produkt.GetType().Name);
            Description = produkt.Info();
            Console.WriteLine(produkt.GetType().Name + "  Info :" +  Description);
            Price = produkt.Buy();
            Console.WriteLine(produkt.GetType().Name + "  Price :" +  Price);
            Console.WriteLine();
            Console.WriteLine("Vill du köpa (Y,N)");
            N = Console.ReadLine();
            if (N.Equals("Y"))
              



            {
                Console.WriteLine();
                Console.WriteLine("Please insert your kard");
                Wallet wallet = new Wallet();
                wallet.Plånbok = 200;
                if (Price <= wallet.Plånbok)
                {
                    Console.WriteLine("Du har till räckligt pengar");
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("DU har inte tillRäckligt pengar i ditt kort ");
                    Console.WriteLine();
                }
                

                    Console.WriteLine("**************************************");
                Använd = produkt.Use();
                Console.WriteLine(produkt.GetType().Name + "  Use :" + Använd);
                Console.WriteLine("Tack att köpte från oss ");
                int c = wallet.Plånbok - Price;
                Console.WriteLine("Det kvar i din Plånbok är :" + c);
                Console.WriteLine();
                Console.WriteLine("Vill du tillbacka till Meny?:)");
                Console.WriteLine("1.Meny");
                Console.WriteLine("2.Avslut");
                S = Console.ReadLine();
                if (S.Equals("1"))

                {


                    
                    goto igen;

                }





                else
                {
                    Console.WriteLine("Tack, Ha en bra dag ");


                }






            }
            else if (N.Equals("N"))
            {
                Console.WriteLine("Hoppas ses Nästa Köp");
                Console.WriteLine("Vill du tillbaka till Meny?");

                goto igen;

            }

            

        }

        
    }
}

