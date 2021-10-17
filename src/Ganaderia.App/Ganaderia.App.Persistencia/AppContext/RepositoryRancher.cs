using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace Ganaderia.App.Persistencia
{
    public class RepositoryRancher : IRepositoryRancher
    {
        private AppContext _appContext;

        public RepositoryRancher(AppContext appContext)
        {
            _appContext = appContext;
        }

        Rancher IRepositoryRancher.AddRancher(Rancher rancher) 
        {
            var AddedRancher = _appContext.Ranchers.Add(rancher);
            _appContext.SaveChanges();
            return AddedRancher.Entity;
        }

        IEnumerable<Rancher> IRepositoryRancher.GetAllRanchers()
        {
            return _appContext.Ranchers;
        }

        Rancher IRepositoryRancher.GetRancher(int idRancher)
        {
            return _appContext.Ranchers.FirstOrDefault(g => g.Id == idRancher);
        }

        Rancher IRepositoryRancher.UpdateRancher(Rancher rancher)
        {
            var FoundRancher = _appContext.Ranchers.FirstOrDefault(g => g.Id == rancher.Id);

            if (FoundRancher != null)
            {
                FoundRancher.Name = rancher.Name;
                FoundRancher.LastName = rancher.LastName;
                

                _appContext.SaveChanges();
            }
            return FoundRancher;
        }

        void IRepositoryRancher.DeleteRancher(int idRancher) {
            var FoundRancher = _appContext.Ranchers.FirstOrDefault(g => g.Id == idRancher);

            if (FoundRancher != null)
            {
                _appContext.Ranchers.Remove(FoundRancher);

                _appContext.SaveChanges();
                }
            }

        // HERD

        Herd IRepositoryRancher.AddHerd(Herd herd) 
        {
            var AddedHerd = _appContext.Herds.Add(herd);
            _appContext.SaveChanges();
            return AddedHerd.Entity;
        }

        IEnumerable<Herd> IRepositoryRancher.GetAllHerds()
        {
            return _appContext.Herds;
        }

        Herd IRepositoryRancher.GetHerd(int idHerd)
        {
            return _appContext.Herds.FirstOrDefault(g => g.Id == idHerd);
        }

        void IRepositoryRancher.DeleteHerd(int idHerd)
        {
            var FoundHerd = _appContext.Herds.FirstOrDefault(g => g.Id == idHerd);

            if (FoundHerd != null)
            {
                _appContext.Herds.Remove(FoundHerd);
                _appContext.SaveChanges();
            }
        }

        //SPECIMENS

        Specimen IRepositoryRancher.AddSpecimen(Specimen specimen)
        {
            var addedSpecimen = _appContext.Specimens.Add(specimen);
            _appContext.SaveChanges();
            return addedSpecimen.Entity;
        }
        
        IEnumerable<Specimen> IRepositoryRancher.GetAllSpecimens()
        {
            return _appContext.Specimens;
        }

        Specimen IRepositoryRancher.GetSpecimen(int idSpecimen)
        {
            return _appContext.Specimens.FirstOrDefault(g => g.Id == idSpecimen);
        }

        void IRepositoryRancher.DeleteSpecimen(int idSpecimen)
        {
            var FoundSpecimen = _appContext.Specimens.FirstOrDefault(g => g.Id == idSpecimen);

            if (FoundSpecimen != null)
            {
                _appContext.Specimens.Remove(FoundSpecimen);
                _appContext.SaveChanges();
            }
        }

        Specimen IRepositoryRancher.UpdateSpecimen(Specimen specimen)
        {
            var FoundSpecimen = _appContext.Specimens.FirstOrDefault(g => g.Id == specimen.Id);

            if (FoundSpecimen != null)
            {
                FoundSpecimen.Gender = specimen.Gender;
                FoundSpecimen.Weight = specimen.Weight;
                FoundSpecimen.Age = specimen.Age;
                FoundSpecimen.Breed = specimen.Breed;
                
                _appContext.SaveChanges();
            }

            return FoundSpecimen;
        }
    }
}