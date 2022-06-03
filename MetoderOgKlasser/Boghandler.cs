namespace MetoderOgKlasser
{
    public class Boghandler
    {
        public static string Sælg(Bog bog)
        {
            --bog.AntalBoger; 
            return "bog solgt";
        }
    }
}
