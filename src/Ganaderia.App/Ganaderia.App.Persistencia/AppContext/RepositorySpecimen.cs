using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public class RepositorySpecimen : IRepositorySpecimen
    {
        private AppContext _appContext;

        public RepositorySpecimen(AppContext appContext)
        {
            _appContext = appContext;
        }
        Specimen IRepositorySpecimen.AddSpecimen(Specimen specimen)
        {
            var AddedSpecimen = _appContext.Specimens.Add(specimen);
            _appContext.SaveChanges();
            return AddedSpecimen.Entity;
        }
        IEnumerable <Specimen> IRepositorySpecimen.GetAllSpecimen()
        {
            return _appContext.Specimens;
        }

        Specimen IRepositorySpecimen.GetSpecimen(int idSpecimen)
        {
            return _appContext.Specimens.FirstOrDefault(g => g.Id == idSpecimen);
        }

        Specimen IRepositorySpecimen.UpdateSpecimen(Specimen specimen)
        {
            var FoundSpecimen = _appContext.Specimens.FirstOrDefault(g => g.Id ==specimen.Id);

            if (FoundSpecimen != null)
            {
                FoundSpecimen.Gender = specimen.Gender;
                FoundSpecimen.Weight = specimen.Weight;
                FoundSpecimen.Age = specimen.Age;
                FoundSpecimen.Breed = specimen.Breed;
            }
            return FoundSpecimen;
        }

        void IRepositorySpecimen.DeleteSpecimen(int idSpecimen)
        {
            var FoundSpecimen = _appContext.Specimens.FirstOrDefault(g => g.Id == idSpecimen);
            
            if (FoundSpecimen != null)
            {
                _appContext.Specimens.Remove(FoundSpecimen);
                _appContext.SaveChanges();
            }
        }
    }
}
