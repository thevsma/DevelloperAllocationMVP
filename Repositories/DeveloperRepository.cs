using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAllocationMVP
{
    internal class DeveloperRepository
    {
        //method used to verify if the developer isn't already in the database, if it is, it changes it's state to 'modified'
        public static void Save(Developer dev)
        {
            try
            {
                using(Repository repos = new Repository())
                {
                    if(dev.Id == 0)
                    {
                        repos.Developers.Add(dev);
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
        public static Developer FindByEmail(String email)
        {
            try
            {
                using(Repository repos = new Repository())
                {
                    return repos.Developers
                        .Include("Credential")
                        .Where(d => d.Credential.Email == email)
                        .FirstOrDefault<Developer>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}