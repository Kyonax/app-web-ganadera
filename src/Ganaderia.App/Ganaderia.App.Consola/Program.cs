using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {
        /// <summary>
        private static IRepositorioUser _repoUser = new RepositorioUser(new Persistencia.AppContext());
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"> </param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddUser();
            //GetAllUsers();
            //GetUser(3);
            //UpdateUser();
            DeleteUser("3");
            
        }

        
        private static void AddUser()
        {
            User user = new User 
            {
                ID = "#001",
                FirstName = "Andres",
                LastName = "Herrera",
                Email = "test@mintic.edu.co",
                Password = "123",
                CitizenID = "158745",
                NumCel = "12345678",
                City = "Villavicencio",
                Adress = "finca 1",
                
            };

            _repoUser.AddUser(user);
        }

        private static void GetAllUsers() {
            /*var user = _repoUser.GetAllUsers();
            foreach(User item in user)
            {
                Console.WriteLine(item.FirstName);
            }   */        
        }

        private static void GetUser(int idUser) 
        {/*
            var user = _repoUser.GetUser(idUser);
            Console.WriteLine(user.FirstName);*/

        }

        private static void UpdateUser() 
        {/*
            User user = new User 
            {
                Id = 3,
                Nombre = "Pedro",
                Apellido = "Herrera",
                NumeroTelefono = "3148569865",
                Correo = "sergio.mintic@mintic.edu.co",
                Contrasena = "12345678",
                Latitud = 121212,
                Longitud = 7887878
            };

            _repoUser.UpdateUser(user);*/

        }

        private static void DeleteUser(string IdUser)
        {
            _repoUser.DeleteUser(IdUser);
        }


    }
}
