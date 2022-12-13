using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAllocationMVP
{
    internal class DevRepos
    {
        //method used to verify if the developer isn't already in the database, if it is, it changes it's state to 'modified'
        public static void Salvar(Desenvolvedor dev)
        {
            try
            {
                using(Repositorio repos = new Repositorio())
                {
                    if(dev.Id == 0)
                    {
                        repos.Desenvolvedores.Add(dev);
                    }
                    else
                    {
                        repos.Entry(dev).State = EntityState.Modified;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //method to find a developer by it's email
        public static Desenvolvedor EncontrarEmail(String email)
        {
            try
            {
                using(Repositorio repos = new Repositorio())
                {
                    return repos.Desenvolvedores.Include("Credencial").Where(d => d.Credencial.Email == email).FirstOrDefault<Desenvolvedor>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
