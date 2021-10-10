using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioUser
    {
        User AddUser(User user);

        IEnumerable<User> GetAllUser();

        User GetUser(string idUser);

        User UpdateUser(User user);

        void DeleteUser(string idUser);
    }
}