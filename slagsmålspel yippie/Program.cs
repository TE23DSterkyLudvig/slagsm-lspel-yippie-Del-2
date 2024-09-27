String name1 = "";
String name2 = "Felix";
string name3 = "Noah";
string kämpenamn = "";
string Fichoice = "";                    //Alltså fighting val
string Fichoice2 = "";
string Fichoice3 = "";


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
            //skada1 *= 1;
            //skada2 *= 1;

            Console.WriteLine($"{name1} slår {name2} och {name2} tar {skada2} i skada");
            Console.WriteLine($"{name2} slår {name1} och {name1} tar {skada1} i skada");
            Hp1 -= skada2;
            Hp2 -= skada1;

            Hp1 = Math.Max(0, Hp1);
            Hp2 = Math.Max(0, Hp2);

            Console.WriteLine($"{name1} har {Hp1} hälsa kvar.");
            Console.WriteLine($"Felix har {Hp2} hälsa kvar");

            Console.ReadLine();
        }
    }

    if (Hp2 <= 0)
    {
        System.Console.WriteLine($" {name1} van med {Hp1} hälsa kvar ");
        System.Console.WriteLine("Tryck på enter för att avsluta spelet");
        var stopp = Console.ReadKey(true);
        if (stopp.Key == ConsoleKey.Enter)
        {
            Environment.Exit(0);
        }
    }

    if (Hp1 <= 0)
    {
        System.Console.WriteLine($" Felix van med {Hp2} hälsa kvar ");
        System.Console.WriteLine("Tryck på enter för att avsluta spelet");
        var stopp = Console.ReadKey(true);
        if (stopp.Key == ConsoleKey.Enter)
        {
            Environment.Exit(0);
        }
    }

    if (Hp1 == 0 && Hp2 == 0)
    {
        System.Console.WriteLine(" Ingen vann för att båda dog.");
        System.Console.WriteLine(" Tryck på enter för att avsluta spelet.");
        var stopp = Console.ReadKey(true);
        if (stopp.Key == ConsoleKey.Enter)
        {
            Environment.Exit(0);
        }
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
            int spark  = Random.Shared.Next(1,50);
            int tombstone = Random.Shared.Next(0,60);
            int spark3 = Random.Shared.Next(20-30);
            int tombstone3 = Random.Shared.Next(7-49);
            //skada1 *= 1;
            //skada2 *= 1;
            Console.WriteLine($"ska {name1} Sparka, Slå Eller Tombstona");
            Fichoice = Console.ReadLine();

            if(Fichoice.ToLower() == "slå"){
                Console.WriteLine($"{name1} slår {name3} och {name3} tar {skada1} i skada");
                 Hp3 -= skada1;
            }

            if (Fichoice.ToLower() == "sparka"){
                Console.WriteLine($"{name1} sparkar {name3} och {name3} tar {spark} i skada");
                Hp3 -= spark;
            }

            if(Fichoice.ToLower() == "Tombstona"){
                Console.WriteLine($"{name1} tombstonar {name3} och {name3} tar {tombstone} i skada");
                Hp3 -= tombstone;
            }
            
            Console.WriteLine($"Ska {name3} slå,sparka eller tombstona");
            Fichoice2 = Console.ReadLine();
           

            Hp1 = Math.Max(0, Hp1);
            Hp3 = Math.Max(0, Hp3);

            Console.WriteLine($"{name1} har {Hp1} hälsa kvar.");
            Console.WriteLine($"Noah har {Hp3} hälsa kvar");

            Console.ReadLine();
        }
    }

    if (Hp3 <= 0)
    {
        System.Console.WriteLine($" {name1} van med {Hp1} hälsa kvar ");
        System.Console.WriteLine("Tryck på enter för att avsluta spelet");
        var stopp = Console.ReadKey(true);
        if (stopp.Key == ConsoleKey.Enter)
        {
            Environment.Exit(0);
        }
    }

    if (Hp1 <= 0)
    {
        System.Console.WriteLine($" noah van med {Hp3} hälsa kvar ");
        System.Console.WriteLine("Tryck på enter för att avsluta spelet");
        var stopp = Console.ReadKey(true);
        if (stopp.Key == ConsoleKey.Enter)
        {
            Environment.Exit(0);
        }
    }

    if (Hp1 == 0 && Hp3 == 0)
    {
        System.Console.WriteLine(" Ingen vann för att båda dog.");
        System.Console.WriteLine(" Tryck på enter för att avsluta spelet.");
        var stopp = Console.ReadKey(true);
        if (stopp.Key == ConsoleKey.Enter)
        {
            Environment.Exit(0);
        }
    }
}


Console.ReadLine();