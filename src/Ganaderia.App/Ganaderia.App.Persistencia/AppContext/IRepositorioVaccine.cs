using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioVaccine
    {
        Vaccine AddVaccine(Vaccine vaccine);

        IEnumerable<Vaccine> GetAllVaccine();

        Vaccine GetVaccine(Int Vaccineid);

        Vaccine UpdateVaccine(Vaccine vaccine);

        void DeleteVaccine(Int Vaccineid);
    }
}