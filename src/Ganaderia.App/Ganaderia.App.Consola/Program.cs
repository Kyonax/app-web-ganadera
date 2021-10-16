using System;
using System.Collections.Generic;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {
        /// <summary>
        private static IRepositoryRancher _repoRancher = new RepositoryRancher(new Persistencia.AppContext());
        private static IRepositoryVet _repoVet = new RepositoryVet(new Persistencia.AppContext());
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"> </param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddRancher();
            //GetAllRanchers();
            //GetRancher(2);
            UpdateRancher();
            //DeleteVet(5);

        }

        
        private static void AddRancher()
        {
            Rancher rancher = new Rancher
            {
                Name = "Fernando",
                LastName = "Gutierrez",
                PhoneNumber = "3148569865",
                Email = "fernando.mintic@mintic.edu.co",
                Password = "12345678",
                CitizenID = "12121223",
                CityOfResidence = "Ibague",
                AmountOfFarms = 5,
            };

            _repoRancher.AddRancher(rancher);
        }

        private static void GetAllRanchers() {
            var Ranchers = _repoRancher.GetAllRanchers();
            foreach(Rancher item in Ranchers)
            {
                Console.WriteLine(item.Name);
            }           
        }

        private static void GetRancher(int idRancher) 
        {
            var Rancher = _repoRancher.GetRancher(idRancher);
            Console.WriteLine(Rancher.Name);

        }

        private static void UpdateRancher() 
        {
            Rancher Rancher = new Rancher 
            {
                Id = 1,
                Name = "Pedro",
                LastName = "Herrera",
                PhoneNumber = "3148569865",
                Email = "sergio.mintic@mintic.edu.co",
                Password = "12345678",
                CitizenID = "12121223",
                CityOfResidence = "Manizales"
            };

            _repoRancher.UpdateRancher(Rancher);

        }

        private static void DeleteVet(int idVet)
        {
            _repoVet.DeleteVet(idVet);
        }


    }
}
