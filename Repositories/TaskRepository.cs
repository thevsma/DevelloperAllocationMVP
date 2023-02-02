using DeveloperAllocationMVP.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAllocationMVP.Repositories
{
    internal class TaskRepository
    {
        public static void Save(Allocation allocation, ProjectTasks p)
        {
            try
            {
                using (Repository repos = new Repository())
                {
                    Allocation alloc = repos.Allocations.FirstOrDefault(a => a.Id == allocation.Id);
                    alloc.Tasks.Add(p);
                    repos.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<ProjectTasks> FindAllTasksByAlloc(Int64 id)
        {
            try
            {
                using (Repository repos = new Repository())
                {
                    Allocation alloc = repos.Allocations.Include(a => a.Tasks).FirstOrDefault(a => a.Id == id);
                    return alloc.Tasks.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
