using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace Ganaderia.App.Persistencia
{
    public class RepositorioUser : IRepositorioUser
    {
        private AppContext _appContext;

        public RepositorioUser(AppContext appContext)
        {
            _appContext = appContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Usuario">Objeto de tipo usuario</param>
        /// <returns></returns>
        User IRepositorioUser.AddUser(User user) 
        {
            var UserAdicionado = _appContext.Users.Add(user);
            _appContext.SaveChanges();
            return UserAdicionado.Entity;
        }

        IEnumerable<User> IRepositorioUser.GetAllUser()
        {
            return _appContext.Users;
        }

        User IRepositorioUser.GetUser(string idUser)
        {
            return _appContext.Users.FirstOrDefault(g => g.IdUser == idUser);
        }

        User IRepositorioUser.UpdateUser(User user)
        {
            var userEncontrado = _appContext.Users.FirstOrDefault(g => g.IdUser == user.IdUser);

            if (userEncontrado != null)
            {
                userEncontrado.FirstName = user.FirstName;
                userEncontrado.lastName = user.lastName;

                ///////////////////////////////////////////////

                _appContext.SaveChanges();
            }

            return userEncontrado;
        }

        void IRepositorioUser.DeleteUser(string idUser) {
            var userEncontrado = _appContext.Users.FirstOrDefault(g => g.IdUser == idUser);

            if (userEncontrado != null)
            {
                _appContext.Users.Remove(userEncontrado);
                _appContext.SaveChanges();
            }

        }
    
    }
}