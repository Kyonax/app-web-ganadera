using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioGanadero
    {
        Ganadero AddGanadero(Ganadero ganadero);

        IEnumerable<Ganadero> GetAllGanaderos();

        Ganadero GetGanadero(int idGanadero);

        Ganadero UpdateGanadero(Ganadero ganadero);

        void DeleteGanadero(int idGanadero);
    }
}