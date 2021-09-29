using System;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AplicationContext : DbContext
    {
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = EmpresaGrupoAlpha;Integrated Security = True";

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Directivo> Directivos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if(!optionsBuilder.IsConfigured){
                    optionsBuilder.UseSqlServer(connectionString);
                }
            }
    }
}