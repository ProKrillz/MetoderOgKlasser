using MetoderOgKlasser;
class program
{
    static void Main()
    {
        Bog test = new Bog { BogId = 1, Titel = "Skyggeriget", Forfatter = "KIM FABER & JANNI PEDERSEN", IsbnNummer = "9788740074918", AntalSider = 416, AntalBoger = 1};
        Console.WriteLine(Boghandler.Sælg(test));
        Console.WriteLine(test.AntalBoger);
    }
} 
