using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public class RepositoryHerd : IRepositoryHerd
    {
        private AppContext _appContext;

        public RepositoryHerd(AppContext appContext)
        {
            _appContext = appContext;
        }
        Herd IRepositoryHerd.AddHerd(Herd herd)
        {
            var AddedHerd = _appContext.Herds.Add(herd);
            _appContext.SaveChanges();
            return AddedHerd.Entity;
        }
        IEnumerable <Herd> IRepositoryHerd.GetAllHerds()
        {
            return _appContext.Herds;
        }

        Herd IRepositoryHerd.GetHerd(int idHerd)
        {
            return _appContext.Herds.FirstOrDefault(g => g.Id == idHerd);
        }

        Herd IRepositoryHerd.UpdateHerd(Herd herd)
        {
            var FoundHerd = _appContext.Herds.FirstOrDefault(g => g.Id ==herd.Id);

            if (FoundHerd != null)
            {
                FoundHerd.AmountOfSpecimen = herd.AmountOfSpecimen;
            }
            return FoundHerd;
        }

        void IRepositoryHerd.DeleteHerd(int idHerd)
        {
            var FoundHerd = _appContext.Herds.FirstOrDefault(g => g.Id == idHerd);
            
            if (FoundHerd != null)
            {
                _appContext.Herds.Remove(FoundHerd);
                _appContext.SaveChanges();
            }
        }
    }
}
