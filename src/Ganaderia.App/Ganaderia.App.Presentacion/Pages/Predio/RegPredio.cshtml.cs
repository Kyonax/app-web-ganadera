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
    public class RegPredioModel : PageModel
    {
        private static IRepositoryFarm _repoFarm = new RepositoryFarm(new Persistencia.AppContext());
        public void OnGet()
        {
        }

        public void OnPostAdd(Farm farm)
        {
            _repoFarm.AddFarm(farm);
        }
    }
}
