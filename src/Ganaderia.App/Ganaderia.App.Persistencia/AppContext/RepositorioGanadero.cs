using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioGanadero : IRepositorioGanadero
    {
        private AppContext _appContext;

         public RepositorioGanadero(AppContext appContext)
        {
            _appContext = appContext;
        }

         Ganadero IRepositorioGanadero.AddGanadero(Ganadero ganadero) {
            var GanaderoAdicionado = _appContext.Ganaderos.Add(ganadero);
            _appContext.SaveChanges();
            return GanaderoAdicionado.Entity;
        }
    }
}