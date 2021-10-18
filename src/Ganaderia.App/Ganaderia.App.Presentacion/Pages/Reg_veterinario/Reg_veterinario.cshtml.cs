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
    public class Reg_veterinarioModel : PageModel
    {
        private static IRepositoryVet _repoVet = new RepositoryVet(new Persistencia.AppContext());
        public IEnumerable<Vet> Vets { get; set; }
        public void OnGet()
        {
            Vets = _repoVet.GetAllVets();
        }

        public void OnPostAdd(Vet vet)
        {
            _repoVet.AddVet(vet);
        }
    }
}
