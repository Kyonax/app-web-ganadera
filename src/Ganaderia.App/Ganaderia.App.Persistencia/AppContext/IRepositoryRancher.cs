using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositoryRancher
    {
        // REGISTRAR - CONSULAR - ELIMINAR - ACTUALIZAR // GANADEROS

        Rancher AddRancher(Rancher rancher);

        IEnumerable<Rancher> GetAllRanchers();

        Rancher GetRancher(int idRancher);

        Rancher UpdateRancher(Rancher rancher);
        
        void DeleteRancher(int idRancher);

        // REGISTRAR - CONSULAR - ELIMINAR - ACTUALIZAR // GANADOS

        Herd AddHerd(Herd herd);

        IEnumerable<Herd> GetAllHerds();

        Herd GetHerd(int idHerd);

        void DeleteHerd(int idHerd);

        // REGISTRAR - CONSULAR - ELIMINAR - ACTUALIZAR // EJEMPLARES

        Specimen AddSpecimen(Specimen specimen);

        Specimen GetSpecimen(int idSpecimen);

        IEnumerable<Specimen> GetAllSpecimens();

        Specimen UpdateSpecimen(Specimen specimen);

        void DeleteSpecimen(int idSpecimen);
    }
}