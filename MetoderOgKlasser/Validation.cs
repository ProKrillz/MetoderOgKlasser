namespace MetoderOgKlasser
{
    public class Validation
    {
        public static string ValidationDouble(string text)
        {
            double output;
            Console.Write(text);
            string? input = Console .ReadLine();
            if (input.Contains(",") && double.TryParse(input, out output))
                return $"indput rigtigt: {output}";
            else
                return "forkert indput";
        }
    }
}
