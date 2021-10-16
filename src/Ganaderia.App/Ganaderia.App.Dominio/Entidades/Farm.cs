using System.Collections.Generic;

namespace Ganaderia.App.Dominio
{
    public class Farm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int AmountOfSpecimen { get; set; }
    }
}