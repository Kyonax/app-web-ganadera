using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia

{
    public interface IRepositoryPathology
    {
        Pathology AddPathology(Pathology pathology);

        IEnumerable<Pathology> GetAllPathology();

        Pathology GetPathology(int idPathology);

        Pathology UpdatePathology(Pathology pathology);

        void DeletePathology(int idPathology);
    }
}
