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
    public class PredioModel : PageModel
    {
        private static IRepositoryFarm _repoFarm = new RepositoryFarm(new Persistencia.AppContext());
        public IEnumerable<Farm> Farms { get; set; }
        public void OnGet()
        {
            Farms = _repoFarm.GetAllFarms();
        }
        public void OnPostDelete(int id){
            _repoFarm.DeleteFarm(id);
            Farms = _repoFarm.GetAllFarms();
        }
    }
}