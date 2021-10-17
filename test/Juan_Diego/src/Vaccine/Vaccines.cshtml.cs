using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Presentacion.Pages
{
    public class VaccinesModel : PageModel
    {
        private static IRepositoryVet _repoVet = new RepositoryVet(new Persistencia.AppContext());

        public IEnumerable<Vaccine> Vaccines { get; set; }
        public void OnGet()
        {
            Vaccines = _repoVet.GetAllVaccines();
        }
    }
}