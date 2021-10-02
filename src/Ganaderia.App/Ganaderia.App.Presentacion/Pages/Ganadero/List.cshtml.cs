using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Presentacion.Pages
{
    public class ListModel : PageModel
    {

        public List<Ganadero> Ganaderos { get; set; }

        public void OnGet()
        {
            Ganadero ganadero = new Ganadero 
            {
                Nombre = "Andres",
                Apellido = "Herrera",
                NumeroTelefono = "3148569865",
                Correo = "sergio.mintic@mintic.edu.co",
                Contrasena = "12345678",
                Latitud = 121212,
                Longitud = 7887878
            };

            Ganadero ganadero2 = new Ganadero 
            {
                Nombre = "Santiago",
                Apellido = "Castro",
                NumeroTelefono = "3148569865",
                Correo = "Santiago@Santiago",
                Contrasena = "12345678",
                Latitud = 121212,
                Longitud = 7887878
            };

            Ganadero ganadero3 = new Ganadero 
            {
                Nombre = "James",
                Apellido = "Rodriguez",
                NumeroTelefono = "3148569865",
                Correo = "James@mintic.edu.co",
                Contrasena = "12345678",
                Latitud = 121212,
                Longitud = 7887878
            };

            Ganadero ganadero4 = new Ganadero 
            {
                Nombre = "Cristiano",
                Apellido = "Ronaldo",
                NumeroTelefono = "3148569865",
                Correo = "Cristiano@mintic.edu.co",
                Contrasena = "12345678",
                Latitud = 121212,
                Longitud = 7887878
            };

            Ganaderos = new List<Ganadero>();
            Ganaderos.Add(ganadero);
            Ganaderos.Add(ganadero2);
            Ganaderos.Add(ganadero3);
            Ganaderos.Add(ganadero4);

        }
    }
}
