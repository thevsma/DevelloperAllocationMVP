﻿using DeveloperAllocationMVP.Entities;
using DeveloperAllocationMVP.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperAllocationMVP
{
    internal class Repository : DbContext
    {
        private static MySqlConnection _dbConnection;
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Allocation> Allocations { get; set; }
        public DbSet<ProjectTasks> Tasks { get; set; }

        public Repository() : base(GetDbConnection(), false)
        {
            if (Database.CreateIfNotExists())
            {
                Repository repos = this;

                //creating a default developer
                Developer devPadrao = new Developer();
                devPadrao.Name = "Matheus";
                DateTime nascDevPadrao = new DateTime(2004, 7, 15);
                devPadrao.Birthday = nascDevPadrao;
                devPadrao.LvlInMemory = 'J';

                //creating a default credential
                Credential credPadrao = new Credential();
                credPadrao.Email = "matheus@gmail.com";
                credPadrao.Password = "prates123@";
                credPadrao.Active = true;
                credPadrao.Admin = true;

                //assigning the developer and the credential to each other
                credPadrao.Developer = devPadrao;
                devPadrao.Credential = credPadrao;

                //creating a default project
                Project projPadrao = new Project();
                projPadrao.Name = "teste";
                DateTime startProjPadrao = new DateTime(2023, 02, 01);
                DateTime plannedCompletionProj = new DateTime(2023, 02, 02);
                projPadrao.Start = startProjPadrao;
                projPadrao.PlannedCompletion = plannedCompletionProj;

                //creating a default allocation
                Allocation alocPadrao = new Allocation();
                DateTime startAlocPadrao = new DateTime(2023, 02, 01);
                DateTime CompletionAlocPadrao = new DateTime(2023, 02, 02);
                alocPadrao.Start = startAlocPadrao;
                alocPadrao.Completion = CompletionAlocPadrao;
                alocPadrao.WeeklyHours = 4;
                alocPadrao.Payment = 50.00m;
                alocPadrao.Developer = devPadrao;
                alocPadrao.Project = projPadrao;

                //adding the default instances to the dbset and saving the changes on the repository
                DeveloperRepository.Save(devPadrao);
                ProjectRepository.Save(projPadrao);
                AllocationRepository.Save(alocPadrao);
                repos.SaveChanges();
            }
        }

        //method that creates a new connection if one doesn't already exists
        public static MySqlConnection GetDbConnection()
        {
            if(_dbConnection == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["DeveloperAllocation"].ConnectionString;
                _dbConnection = new MySqlConnection(connectionString);
            }
            return _dbConnection;
        }
    }
}
