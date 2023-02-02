using DeveloperAllocationMVP.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
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
                        repos.SaveChanges();
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

        public static List<Project> FindAll()
        {
            try
            {
                using (Repository repos = new Repository())
                {
                    return repos.Projects.ToList();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static Project FindById(Int64 id)
        {
            try
            {
                using(Repository repos = new Repository())
                {
                    return repos.Projects.Find(id);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static List<Project> FindByPartialName(String name)
        {
            try
            {
                using(Repository repos = new Repository())
                {
                    return repos.Projects.Where(d => d.Name.Contains(name)).ToList<Project>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
