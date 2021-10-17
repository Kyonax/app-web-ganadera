using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia

{
    public interface IRepositoryHerd
    {
        Herd AddHerd(Herd herd);

        IEnumerable<Herd> GetAllHerds();

        Herd GetHerd(int idHerds);

        Herd UpdateHerd(Herd herd);

        void DeleteHerd(int idHerd);
    }
}
