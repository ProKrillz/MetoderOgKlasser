namespace MetoderOgKlasser
{
    public class Forlag
    {
        static int _bogCounter;
        static public List<Bog> BogList { get; set; }

        static public void Modtage(ref Bog bog)
        {
            bog.BogId = ++_bogCounter;
            BogList.Add(bog);
        }
    }
}
