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
    public class RanchersModel : PageModel
    {
        private static IRepositoryRancher _repoRancher = new RepositoryRancher(new Persistencia.AppContext());

        public IEnumerable<Rancher> Ranchers { get; set; }

        public void OnGet()
        {
            Ranchers = _repoRancher.GetAllRanchers();
        }
    }
}