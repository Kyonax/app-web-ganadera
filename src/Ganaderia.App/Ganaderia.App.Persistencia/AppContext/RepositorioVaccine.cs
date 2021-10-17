using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace Ganaderia.App.Persistencia
{
    public class RepositorioVaccine : IRepositorioVaccine
    {
        private AppContext _appContext;

        public RepositorioVaccine(AppContext appContext)
        {
            _appContext = appContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Vacuna">Objeto de tipo usuario</param>
        /// <returns></returns>
        Vaccine IRepositorioVaccine.AddVaccine(Vaccine vaccine) 
        {
            var VaccineAdicionado = _appContext.Vaccines.Add(vaccine);
            _appContext.SaveChanges();
            return VaccineAdicionado.Entity;
        }

        IEnumerable<Vaccine> IRepositorioVaccine.GetAllVaccine()
        {
            return _appContext.Vaccines;
        }

        Vaccine IRepositorioVaccine.GetVaccine(int Vaccineid)
        {
            return _appContext.Vaccines.FirstOrDefault(g => g.VaccineId == Vaccineid);
        }

        Vaccine IRepositorioVaccine.UpdateVaccine(Vaccine vaccine)
        {
            var vaccineEncontrado = _appContext.Vaccines.FirstOrDefault(g => g.ID == vaccine.ID);

            if (vaccineEncontrado != null)
            {
                vaccineEncontrado.Name = vaccine.Name;
                vaccineEncontrado.LastName = vaccine.LastName;
                _appContext.SaveChanges();
            }

            return vaccineEncontrado;
        }

        void IRepositorioVaccine.DeleteVaccine(int Vaccineid) {
            var vaccineEncontrado = _appContext.Vaccines.FirstOrDefault(g => g.ID == Vaccineid);

            if (vaccineEncontrado != null)
            {
                _appContext.Vaccines.Remove(vaccineEncontrado);
                _appContext.SaveChanges();
            }

        }
    
    }
}