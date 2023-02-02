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
                        repos.SaveChanges();
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

        public static List<Allocation> FindByDevOrProj(String name)
        {
            try
            {
                using(Repository repos = new Repository())
                {
                    return repos.Allocations.Include(a => a.Developer).Include(a => a.Project).Where(a => a.Developer.Name.Contains(name) || a.Project.Name.Contains(name)).ToList<Allocation>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
