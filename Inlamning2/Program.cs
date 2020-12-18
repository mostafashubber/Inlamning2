using System;
using System.Collections.Generic;
using System.Linq;

namespace Inlamning2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Här läggs in medlemmarna i listan
            List<Basgrupp> MedlemsListan = new List<Basgrupp>()
            {

                   new Basgrupp{Födelsedatum=1987, Namn="Mostafa", Födelseort="Stockholm", Land="Sverige", Stad="Stockholm", Längd= 174,
                        Civilstatus="Ogift", intresse="Träning", Favoritmat="Oxfile", Motivation="Tycker om att koda och lösa problem"},
                         new Basgrupp{Födelsedatum=1985, Namn="Mohammed", Födelseort="Stockholm", Land="Sverige", Stad="Stockholm", Längd= 180,
                        Civilstatus="Skild", intresse="MC och bil", Favoritmat="Kyckling med pasta", Motivation="Tycker mest om att koda i java och .net"},
                        new Basgrupp{Födelsedatum=1992, Namn="Amin", Födelseort="Stockholm", Land="Sverige", Stad="Stockholm", Längd= 177,
                        Civilstatus="Ogift", intresse="Kampsport", Favoritmat="Laxfile med potatis", Motivation="Amin tycker om att lära sig nya saker"},
                           new Basgrupp{Födelsedatum=1989, Namn="Emil", Födelseort="Stockholm", Land="Sverige", Stad="Stockholm", Längd= 185,
                        Civilstatus="Gift", intresse="Skytteklubb", Favoritmat="Lasagne", Motivation="Emil är bäst på att koda inom sharepoint"}
            };

            Basgrupp _basgruppen = new Basgrupp();//Hämtar en variabel från Basgrupp.cs

            //Variabel till koden för att användaren skall kunna logga in
            Console.WriteLine("Ange kod");
            var kod = Console.ReadLine();

            //Om koden är rätt, kommer användaren få fyra olika alternativ
            if (kod == "Campus")
            {
                Console.WriteLine("Välkommen");
                Console.WriteLine("[1] Visa listan");
                Console.WriteLine("[2] Sök efter en person");
                Console.WriteLine("[3] Ta bort en medlem");
                Console.WriteLine("[4] Avsluta programmet");
            }

            //Om koden är felaktig, kommer följande meddelande visas i skärmen
            else if (kod != "Campus" || kod == null)
            {
                Console.WriteLine("Felaktig kod");
            }

            //Skapade en while(true) för att programmet skall fortsätta tills användaren väljer när hon/han skall avsluta

            while (true)
            {
                int val = int.Parse(Console.ReadLine());

                //Här visas alla deltagare som finns med i listan
                if (val == 1)
                {

                    foreach (var medlem in MedlemsListan)
                    {
                        Console.WriteLine($"Födelsedatum: {medlem.Födelsedatum} Namn: {medlem.Namn} Födelseort: {medlem.Födelseort} " +
                            $"Land: {medlem.Land} Stad: {medlem.Stad} " +
                                    $"Längd: {medlem.Längd} Civilstatus: {medlem.Civilstatus} Intresse: {medlem.intresse} " +
                                    $"Favoritmat: {medlem.Favoritmat} Motivation till programmering: {medlem.Motivation},");
                    }
                }

                //Här visas personen vid sökning
                else if (val == 2)
                {

                    Console.WriteLine("Ange namn");
                    string SökPerson = Console.ReadLine();
                    foreach (var medlem in MedlemsListan.Where(x => x.Namn == SökPerson))
                    {
                        Console.WriteLine($"Födelsedatum: {medlem.Födelsedatum} Namn: {medlem.Namn} Födelseort: {medlem.Födelseort} " +
                            $"Land: {medlem.Land} Stad: {medlem.Stad} " +
                                    $"Längd: {medlem.Längd} Civilstatus: {medlem.Civilstatus} Intresse: {medlem.intresse} " +
                                    $"Favoritmat: {medlem.Favoritmat} Motivation till programmering: {medlem.Motivation}");
                    }

                }

                //Här raderas personen
                else if (val == 3)
                {

                    Console.WriteLine("Ange namn");
                    string RaderaPerson = Console.ReadLine();
                    MedlemsListan.RemoveAll(x => x.Namn == RaderaPerson);
                    Console.WriteLine($"Nu är {RaderaPerson} borttagen");


                }

                //Programmet avslutas 
                else if (val == 4)
                {

                    Console.WriteLine("Du avslutade programmet");
                    break;

                }

            }
            Console.ReadLine();

        }
    }
}
