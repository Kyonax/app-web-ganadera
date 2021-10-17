using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace Ganaderia.App.Persistencia
{
    public class RepositoryVaccine : IRepositoryVaccine
    {
        private AppContext _appContext;

        public RepositoryVaccine(AppContext appContext)
        {
            _appContext = appContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Vacuna">Objeto de tipo usuario</param>
        /// <returns></returns>
        Vaccine IRepositoryVaccine.AddVaccine(Vaccine vaccine) 
        {
            var VaccineAdicionado = _appContext.Vaccines.Add(vaccine);
            _appContext.SaveChanges();
            return VaccineAdicionado.Entity;
        }

        IEnumerable<Vaccine> IRepositoryVaccine.GetAllVaccine()
        {
            return _appContext.Vaccines;
        }

        Vaccine IRepositoryVaccine.GetVaccine(int Vaccineid)
        {
            return _appContext.Vaccines.FirstOrDefault(g => g.Id == Vaccineid);
        }

        Vaccine IRepositoryVaccine.UpdateVaccine(Vaccine vaccine)
        {
            var vaccineEncontrado = _appContext.Vaccines.FirstOrDefault(g => g.Id == vaccine.Id);

            if (vaccineEncontrado != null)
            {
                vaccineEncontrado.Name = vaccine.Name;
                vaccineEncontrado.Lot = vaccine.Lot;
                vaccineEncontrado.Lab = vaccine.Lab;
                vaccineEncontrado.KeepCool = vaccine.KeepCool;

                _appContext.SaveChanges();
            }

            return vaccineEncontrado;
        }

        void IRepositoryVaccine.DeleteVaccine(int Vaccineid) {
            var vaccineEncontrado = _appContext.Vaccines.FirstOrDefault(g => g.Id == Vaccineid);

            if (vaccineEncontrado != null)
            {
                _appContext.Vaccines.Remove(vaccineEncontrado);
                _appContext.SaveChanges();
            }

        }
    
    }
}