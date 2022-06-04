using MetoderOgKlasser;
class program
{
    static void Main()
    {
        Bog test = new Bog { BogId = 1, Titel = "Skyggeriget", Forfatter = "KIM FABER & JANNI PEDERSEN", IsbnNummer = "9788740074918", AntalSider = 416, AntalBoger = 1};
        Console.WriteLine(Boghandler.Sælg(test));
        Console.WriteLine(test.AntalBoger);

        Kunder kd1 = new Kunder { Navn = "Thomas", Addresse = "Bronx" };
        Console.WriteLine(kd1);

        Console.WriteLine(Validation.ValidationDouble("Skriv et tal: ")); 
    }
} 
