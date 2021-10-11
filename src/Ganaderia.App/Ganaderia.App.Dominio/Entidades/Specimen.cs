namespace Ganaderia.App.Dominio
{
    public class Specimen : Livestock
    {
        public string _id { get; set; }
        public string gender { get; set; }
        public string weight { get; set; }
        public int age { get; set; }
        public string race { get; set; }
        public string vaccines { get; set; }
        public string pathologies { get; set; }

    }
}
