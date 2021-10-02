using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace Ganaderia.App.Persistencia
{
    public class RepositorioGanadero : IRepositorioGanadero
    {
        private AppContext _appContext;

        public RepositorioGanadero(AppContext appContext)
        {
            _appContext = appContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ganadero">Objeto de tipo ganadero</param>
        /// <returns></returns>
        Ganadero IRepositorioGanadero.AddGanadero(Ganadero ganadero) 
        {
            var GanaderoAdicionado = _appContext.Ganaderos.Add(ganadero);
            _appContext.SaveChanges();
            return GanaderoAdicionado.Entity;
        }

        IEnumerable<Ganadero> IRepositorioGanadero.GetAllGanaderos()
        {
            return _appContext.Ganaderos;
        }

        Ganadero IRepositorioGanadero.GetGanadero(int idGanadero)
        {
            return _appContext.Ganaderos.FirstOrDefault(g => g.Id == idGanadero);
        }

        Ganadero IRepositorioGanadero.UpdateGanadero(Ganadero ganadero)
        {
            var ganaderoEncontrado = _appContext.Ganaderos.FirstOrDefault(g => g.Id == ganadero.Id);

            if (ganaderoEncontrado != null)
            {
                ganaderoEncontrado.Nombre = ganadero.Nombre;
                ganaderoEncontrado.Apellido = ganadero.Apellido;

                ///////////////////////////////////////////////

                _appContext.SaveChanges();
            }

            return ganaderoEncontrado;
        }

        void IRepositorioGanadero.DeleteGanadero(int idGanadero) {
            var ganaderoEncontrado = _appContext.Ganaderos.FirstOrDefault(g => g.Id == idGanadero);

            if (ganaderoEncontrado != null)
            {
                _appContext.Ganaderos.Remove(ganaderoEncontrado);
                _appContext.SaveChanges();
            }

        }
    
    }
}