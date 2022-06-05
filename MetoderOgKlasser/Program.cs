using MetoderOgKlasser;
class Program
{
    static void Main(string[] args)
    {
        Forlag.BogList = new List<Bog>();
        Bog minBog = new Bog { Titel = "bog1", Forfatter = "Ham", IsbnNummer = "1234", AntalSider = 60, AntalBoger = 1};
        Bog bogen = new Bog { Titel = "bog2", Forfatter = "Hende", IsbnNummer = "1234", AntalSider = 70, AntalBoger = 1};
        Forlag.Modtage(ref minBog);
        Forlag.Modtage(ref bogen);
        foreach (var item in Forlag.BogList)
        {
            Console.WriteLine(item.BogId);
            Console.WriteLine(item.Titel);
            Console.WriteLine(item.Forfatter);
            Console.WriteLine(item.IsbnNummer);
            Console.WriteLine(item.AntalSider);
            Console.WriteLine(item.AntalBoger);
            
        }
        
    }
}
