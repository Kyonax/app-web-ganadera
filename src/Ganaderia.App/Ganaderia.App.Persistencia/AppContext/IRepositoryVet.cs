using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositoryVet
    {
        Vet AddVet (Vet vet);
        IEnumerable<Vet> GetAllVets();
        Vet GetVet (int idVet);
        Vet UpdateVet (Vet vet);
        void DeleteVet (int idVet);

        //Vaccine AddVaccine (Vaccine vaccine);
        //IEnumerable<Vaccine> GetAllVaccines();
        //Vaccine GetVaccine (int idVaccine);
        //Vaccine UpdateVaccine (Vaccine vaccine);
        //void DeleteVaccine (int idVaccine);
    }
}