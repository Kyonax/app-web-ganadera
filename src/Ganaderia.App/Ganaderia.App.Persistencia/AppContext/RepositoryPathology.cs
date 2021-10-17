using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public class RepositoryPathology : IRepositoryPathology
    {
        private AppContext _appContext;

        public RepositoryPathology(AppContext appContext)
        {
            _appContext = appContext;
        }
        Pathology IRepositoryPathology.AddPathology(Pathology pathology)
        {
            var AddedPathology = _appContext.Pathology.Add(pathology);
            _appContext.SaveChanges();
            return AddedPathology.Entity;
        }
        IEnumerable <Pathology> IRepositoryPathology.GetAllPathology()
        {
            return _appContext.Pathology;
        }

        Pathology IRepositoryPathology.GetPathology(int idPathology)
        {
            return _appContext.Pathology.FirstOrDefault(g => g.Id == idPathology);
        }

        Pathology IRepositoryPathology.UpdatePathology(Pathology pathology)
        {
            var FoundPathology = _appContext.Pathology.FirstOrDefault(g => g.Id ==pathology.Id);

            if (FoundPathology != null)
            {
                FoundPathology.Name = pathology.Name;
                FoundPathology.ClinicalSigns = pathology.ClinicalSigns;
            }
            return FoundPathology;
        }

        void IRepositoryPathology.DeletePathology(int idPathology)
        {
            var FoundPathology = _appContext.Pathology.FirstOrDefault(g => g.Id == idPathology);
            
            if (FoundPathology != null)
            {
                _appContext.Pathology.Remove(FoundPathology);
                _appContext.SaveChanges();
            }
        }
    }
}
