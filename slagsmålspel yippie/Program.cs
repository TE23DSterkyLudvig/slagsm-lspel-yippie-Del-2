﻿

 fight();
static void fight(){

String name1 = "";
String name2 = "Felix";
string name3 = "Noah";
string kämpenamn = "";
string Fichoice = "";                    //Alltså fighting val
string Fichoice2 = "";
string Fichoice3 = "";
string svarigen = "";


int Hp1 = 100;
int Hp2 = 100;
int Hp3 = 120;

System.Console.WriteLine("Vad vill du heta?");
name1 = Console.ReadLine();

System.Console.WriteLine("vem vill du möta? Noah eller Felix");
kämpenamn = Console.ReadLine();

while (kämpenamn != name3 && kämpenamn != name2)
{
    System.Console.WriteLine("Skriv in Noah Eller Felix");
    kämpenamn = Console.ReadLine();
}

if (kämpenamn.ToLower() == "felix")
{
    Console.WriteLine(@$"{name1} och {name2} ska slåss.
Tryck på enter för att börja spelet");
    var key = Console.ReadKey(true);
    if (key.Key == ConsoleKey.Enter)
    {
        while (Hp1 > 0 && Hp2 > 0)
        {
            int skada1 = Random.Shared.Next(5, 35);
            int skada2 = Random.Shared.Next(2, 40);
            int spark = Random.Shared.Next(1, 50);
            int tombstone = Random.Shared.Next(10, 60);
            int uppercut2 = Random.Shared.Next(21, 43);
            int skjut2 = Random.Shared.Next(12, 34);
            //skada1 *= 1;
            //skada2 *= 1;

            Console.WriteLine($"ska {name1} Sparka, Slå Eller Tombstona");
            Console.WriteLine("Skriv 1 för att slå. Skriva 2 För att sparka. Skriv 3 för att tombstona");
            Fichoice = Console.ReadLine();

            while (Fichoice != "3" && Fichoice != "2" && Fichoice != "1")
            {
                System.Console.WriteLine("Skriv ett av alternativen!");
                Fichoice = Console.ReadLine();
            }

            if (Fichoice.ToLower() == "1")
            {
                Console.WriteLine($"{name1} slår {name2} och {name2} tar {skada1} i skada");
                Hp2 -= skada1;
            }

            else if (Fichoice.ToLower() == "2")
            {
                Console.WriteLine($"{name1} sparkar {name2} och {name2} tar {spark} i skada");
                Hp2 -= spark;
            }

            else if (Fichoice.ToLower() == "3")
            {
                Console.WriteLine($"{name1} tombstonar {name2} och {name2} tar {tombstone} i skada");
                Hp2 -= tombstone;
            }



            Console.WriteLine($"ska {name2} uppercuta, Slå Eller skjuta");
            Console.WriteLine("Skriv 1 för att slå. Skriv 2 för att Uppercuta. Skriv 3 för att skjuta.");
            Fichoice2 = Console.ReadLine();

            while (Fichoice2 != "3" && Fichoice2 != "2" && Fichoice2 != "1")
            {
                System.Console.WriteLine("Skriv ett av alternativen!");
                Fichoice2 = Console.ReadLine();
            }

            if (Fichoice2 == "1")
            {
                Console.WriteLine($"{name2} slår {name1} och {name1} tar {skada2} i skada");
                Hp1 -= skada2;
            }

            else if (Fichoice2 == "2")
            {
                Console.WriteLine($"{name2} sparkar {name1} och {name1} tar {uppercut2} i skada");
                Hp1 -= uppercut2;
            }

            else if (Fichoice2 == "3")
            {
                Console.WriteLine($"{name1} skjuter {name3} och {name3} tar {skjut2} i skada");
                Hp1 -= skjut2;
            }


            Hp1 = Math.Max(0, Hp1);
            Hp2 = Math.Max(0, Hp2);

            Console.WriteLine($"{name1} har {Hp1} hälsa kvar.");
            Console.WriteLine($"{kämpenamn} har {Hp2} hälsa kvar");

            System.Console.WriteLine(@" 
            Tryck på Enter för start om loopen");
            Console.ReadLine();
        }
    }

    if (Hp2 <= 0)
    {
        System.Console.WriteLine($" {name1} van med {Hp1} hälsa kvar ");
        System.Console.WriteLine("Tryck på Tab för att avsluta spelet eller enter för att få fram fråga om att starta om");
        var stopp = Console.ReadKey(true);
        if (stopp.Key == ConsoleKey.Tab)
        {
            Environment.Exit(0);
        }
    }

    if (Hp1 <= 0)
    {
        System.Console.WriteLine($" Felix van med {Hp2} hälsa kvar ");
        System.Console.WriteLine("Tryck på Tab för att avsluta spelet eller enter för att få fram fråga om att starta om");
        var stopp = Console.ReadKey(true);
        if (stopp.Key == ConsoleKey.Tab)
        {
            Environment.Exit(0);
        }
    }

    if (Hp1 == 0 && Hp2 == 0)
    {
        System.Console.WriteLine(" Ingen vann för att båda dog.");
        System.Console.WriteLine(" Tryck på Tab för att avsluta spelet eller enter för att få fram fråga om att starta om.");
        var stopp = Console.ReadKey(true);
        if (stopp.Key == ConsoleKey.Tab)
        {
            Environment.Exit(0);
        }
    }
    if(key.Key == ConsoleKey.Enter)
    System.Console.WriteLine("Vill du spela igen?");
    svarigen = Console.ReadLine();
    if(svarigen.ToLower() == "ja"){
        fight();
    }
    else if(svarigen.ToLower() == "nej")
    {
      Environment.Exit(0);
    }
}


if (kämpenamn.ToLower() == "noah")
{
    Console.WriteLine(@$"{name1} och {name3} ska slåss.
Tryck på enter för att börja spelet");
    var key = Console.ReadKey(true);
    if (key.Key == ConsoleKey.Enter)
    {
        while (Hp1 > 0 && Hp3 > 0)
        {
            int skada1 = Random.Shared.Next(2, 35);
            int skada3 = Random.Shared.Next(5, 20);
            int spark = Random.Shared.Next(1, 50);
            int tombstone = Random.Shared.Next(10, 60);
            int spark3 = Random.Shared.Next(20, 30);
            int tombstone3 = Random.Shared.Next(7, 49);
            //skada1 *= 1;
            //skada2 *= 1;
            Console.WriteLine($"ska {name1} Sparka, slå Eller Tombstona");
            System.Console.WriteLine("Skriv 1 för att Slå. Skriv 2 för att sparka. Skriv 3 för att tombstona");
            Fichoice = Console.ReadLine();

            while (Fichoice != "3" && Fichoice != "2" && Fichoice != "1")
            {
                System.Console.WriteLine("Skriv ett av alternativen!");
                Fichoice = Console.ReadLine();
            }

            if (Fichoice == "1")
            {
                Console.WriteLine($"{name1} slår {name3} och {name3} tar {skada1} i skada");
                Hp3 -= skada1;
            }

            else if (Fichoice == "2")
            {
                Console.WriteLine($"{name1} sparkar {name3} och {name3} tar {spark} i skada");
                Hp3 -= spark;
            }

            else if (Fichoice == "3")
            {
                Console.WriteLine($"{name1} tombstonar {name3} och {name3} tar {tombstone} i skada");
                Hp3 -= tombstone;
            }

            Console.WriteLine($"Ska {name3} slå, sparka eller tombstona");
            System.Console.WriteLine("Skriv 1 för att slå, skriv 2 för att sparka, skriv 3 för att tombstona");
            Fichoice3 = Console.ReadLine();

            while (Fichoice3 != "3" && Fichoice3 != "2" && Fichoice3 != "1")
            {
                System.Console.WriteLine("Skriv ett av alternativen!");
                Fichoice3 = Console.ReadLine();
            }

            if (Fichoice3 == "1")
            {
                System.Console.WriteLine($"{name3} slår {name1} och {name1} tar {skada3} i skada");
                Hp1 -= skada3;
            }
            else if (Fichoice3 == "2")
            {
                System.Console.WriteLine($"{name3} sparkar {name1} och {name1} tar {spark3} i skada");
                Hp1 -= spark3;
            }
            else if (Fichoice3 == "3")
            {
                System.Console.WriteLine($"{name3} tombstonar {name1} och {name1} tar {tombstone3} i skada");
                Hp1 -= spark3;
            }

            //while(Fichoice3 != "tombstona" || Fichoice3 != "sparka" || Fichoice3 != "slå"){
            //    System.Console.WriteLine("Skriv ett av alternativen!");
            //  Console.ReadLine();
            //}

            Hp1 = Math.Max(0, Hp1);
            Hp3 = Math.Max(0, Hp3);

            Console.WriteLine($"{name1} har {Hp1} hälsa kvar.");
            Console.WriteLine($"{name3} har {Hp3} hälsa kvar");

            System.Console.WriteLine("Tryck på enter för att starta om loopen.");
            Console.ReadLine();
        }
    }

    if (Hp3 <= 0)
    {
        System.Console.WriteLine($" {name1} van med {Hp1} hälsa kvar ");
        System.Console.WriteLine("Tryck på tab för att avsluta spelet eller enter för att få fram fråga om att starta om");
        var stopp = Console.ReadKey(true);
        if (stopp.Key == ConsoleKey.Tab)
        {
            Environment.Exit(0);
        }
    }


    if (Hp1 <= 0)
    {
        System.Console.WriteLine($" noah vann med {Hp3} hälsa kvar ");
        System.Console.WriteLine("Tryck på tab för att avsluta spelet eller enter för att få fram fråga om att starta om");
        var stopp = Console.ReadKey(true);
        if (stopp.Key == ConsoleKey.Tab)
        {
            Environment.Exit(0);
        }
    }

    if (Hp1 == 0 && Hp3 == 0)
    {
        System.Console.WriteLine(" Ingen vann för att båda dog.");
        System.Console.WriteLine(" Tryck på Tab för att avsluta spelet eller enter för att få fram fråga om att starta om.");
        var stopp = Console.ReadKey(true);
        if (stopp.Key == ConsoleKey.Tab)
        {
            Environment.Exit(0);
        }
    }
    System.Console.WriteLine("Vill du spela igen?");
    svarigen = Console.ReadLine();
    if(svarigen.ToLower() == "ja"){
        fight();
    }
    else if(svarigen.ToLower() == "nej")
    {
      Environment.Exit(0);
    }
}

}


Console.ReadLine();