using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public class RepositoryVet : IRepositoryVet
    {
        private AppContext _appContext;

        public RepositoryVet(AppContext appContext)
        {
            _appContext = appContext;
        }

        Vet IRepositoryVet.AddVet(Vet vet)
        {
            var AddedVet = _appContext.Vets.Add(vet);
            _appContext.SaveChanges();
            return AddedVet.Entity;
        }

        IEnumerable<Vet> IRepositoryVet.GetAllVets()
        {
            return _appContext.Vets;
        }

        Vet IRepositoryVet.GetVet(int idVet)
        {
            return _appContext.Vets.FirstOrDefault(g => g.Id == idVet);
        }

        Vet IRepositoryVet.UpdateVet(Vet vet)
        {
            var FoundVet = _appContext.Vets.FirstOrDefault(g => g.Id == vet.Id);

            if (FoundVet != null)
            {
                FoundVet.Name = vet.Name;
                FoundVet.LastName = vet.LastName;
                FoundVet.PhoneNumber = vet.PhoneNumber;
                FoundVet.Email = vet.Email;
                FoundVet.Password = vet.Password;
                FoundVet.CitizenID = vet.CitizenID;
                FoundVet.CityOfResidence = vet.CityOfResidence;
            }
            return FoundVet;
        }

        void IRepositoryVet.DeleteVet(int idVet)
        {
            var FoundVet = _appContext.Vets.FirstOrDefault(g => g.Id == idVet);

            if (FoundVet != null)
            {
                _appContext.Vets.Remove(FoundVet);
                _appContext.SaveChanges();
            }
        }
    }
}