using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public class RepositoryFarm : IRepositoryFarm
    {
        private AppContext _appContext;

        public RepositoryFarm(AppContext appContext)
        {
            _appContext = appContext;
        }
        Farm IRepositoryFarm.AddFarm(Farm farm)
        {
            var AddedFarm = _appContext.Farms.Add(farm);
            _appContext.SaveChanges();
            return AddedFarm.Entity;
        }
        IEnumerable <Farm> IRepositoryFarm.GetAllFarms()
        {
            return _appContext.Farms;
        }

        Farm IRepositoryFarm.GetFarm(int idFarm)
        {
            return _appContext.Farms.FirstOrDefault(g => g.Id == idFarm);
        }

        Farm IRepositoryFarm.UpdateFarm(Farm farm)
        {
            var FoundFarm = _appContext.Farms.FirstOrDefault(g => g.Id ==farm.Id);

            if (FoundFarm != null)
            {
                FoundFarm.Name = farm.Name;
                FoundFarm.Latitud = farm.Latitud;
                FoundFarm.Longitud = farm.Longitud;
                FoundFarm.Address = farm.Address;
                FoundFarm.City = farm.City;
                FoundFarm.AmountOfSpecimen = farm.AmountOfSpecimen;
            }
            return FoundFarm;
        }

        void IRepositoryFarm.DeleteFarm(int idFarm)
        {
            var FoundFarm = _appContext.Farms.FirstOrDefault(g => g.Id == idFarm);
            
            if (FoundFarm != null)
            {
                _appContext.Farms.Remove(FoundFarm);
                _appContext.SaveChanges();
            }
        }
    }
}