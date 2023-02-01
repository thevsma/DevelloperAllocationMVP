using DeveloperAllocationMVP.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAllocationMVP.Repositories
{
    internal class AllocationRepository
    {
        public static void Save(Allocation a)
        {
            try
            {
                using (Repository repos = new Repository())
                {
                    repos.Entry(a.Developer).State = EntityState.Unchanged;
                    repos.Entry(a.Project).State = EntityState.Unchanged;

                    if (a.Id == 0)
                    {
                        repos.Allocations.Add(a);
                    }
                    else
                    {
                        repos.Entry(a).State = EntityState.Modified;
                    }

                    repos.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Allocation> FindAllAllocations()
        {
            try
            {
                using (Repository repos = new Repository())
                {
                    return repos.Allocations.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
