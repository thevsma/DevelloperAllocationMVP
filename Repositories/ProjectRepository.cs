using DeveloperAllocationMVP.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAllocationMVP.Repositories
{
    internal class ProjectRepository
    {
        public static void Save(Project project)
        {
            try
            {
                using(Repository repos = new Repository())
                {
                    if(project.Id == 0)
                    {
                        repos.Projects.Add(project);
                    }
                    else
                    {
                        repos.Entry(project).State = EntityState.Modified;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
