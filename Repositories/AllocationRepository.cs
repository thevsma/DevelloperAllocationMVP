using DeveloperAllocationMVP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAllocationMVP.Repositories
{
    internal class AllocationRepository
    {
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
