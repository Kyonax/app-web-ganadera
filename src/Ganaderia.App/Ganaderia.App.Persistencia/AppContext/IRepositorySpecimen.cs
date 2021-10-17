using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia

{
    public interface IRepositorySpecimen
    {
        Specimen AddSpecimen(Specimen specimen);

        IEnumerable<Specimen> GetAllSpecimen();

        Specimen GetSpecimen(int idSpecimen);

        Specimen UpdateSpecimen(Specimen specimen);

        void DeleteSpecimen(int idSpecimen);
    }
}
