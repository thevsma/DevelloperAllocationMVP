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
    internal class Repositorio : DbContext
    {
        private static MySqlConnection _dbConnection;
        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }

        public Repositorio() : base(GetDbConnection(), false)
        {
            if (Database.CreateIfNotExists())
            {
                Repositorio repos = this;

                //creating a default developer
                Desenvolvedor devPadrao = new Desenvolvedor();
                devPadrao.Nome = "Matheus";
                DateTime nascDevPadrao = new DateTime(2004, 7, 15);
                devPadrao.Nascimento = nascDevPadrao;
                devPadrao.NivelMemoria = 'J';

                //creating a default credential
                Credencial credPadrao = new Credencial();
                credPadrao.Email = "matheus@gmail.com";
                credPadrao.Senha = "prates123@";
                credPadrao.Ativo = true;
                credPadrao.Admin = true;

                //assigning the developer and the credential to each other
                devPadrao.Credencial = credPadrao;
                credPadrao.Desenvolvedor = devPadrao;

                //adding the default developer to the dbset and saving the changes on the repository
                repos.Desenvolvedores.Add(devPadrao);
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
