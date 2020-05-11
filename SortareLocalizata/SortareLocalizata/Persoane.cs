namespace SortareLocalizata
{
    public class Persoane
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public string nationalitate { get; set; }
        public Persoane(string nume, string prenume, string nationalitate)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.nationalitate = nationalitate;

        }
        public static string Capital(string capital)
        {
            capital.ToUpper();
            return capital;
        }
    }
}