using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia

{
    public interface IRepositoryFarm
    {
        Farm AddFarm(Farm farm);

        IEnumerable<Farm> GetAllFarms();

        Farm GetFarm(int idFarm);

        Farm UpdateFarm(Farm farm);

        void DeleteFarm(int idFarm);
    }
}