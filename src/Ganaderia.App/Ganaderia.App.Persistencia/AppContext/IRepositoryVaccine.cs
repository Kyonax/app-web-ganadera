using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositoryVaccine
    {
        Vaccine AddVaccine(Vaccine vaccine);

        IEnumerable<Vaccine> GetAllVaccine();

        Vaccine GetVaccine(int Vaccineid);

        Vaccine UpdateVaccine(Vaccine vaccine);

        void DeleteVaccine(int Vaccineid);
    }
}