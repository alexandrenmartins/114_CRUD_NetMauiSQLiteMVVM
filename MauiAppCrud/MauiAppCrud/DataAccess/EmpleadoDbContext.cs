
using MauiAppCrud.Modelos;
using MauiAppCrud.Utilidades;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MauiAppCrud.DataAccess
{
    public class EmpleadoDbContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //NA STRING DE CONEXÃO PODEMOS USAR 'Filename=' OU 'Data Source='
            //string conexionDB = $"Filename={ConexionDB.DevolverRuta("empleados.db")}";
            string conexionDB = $"Data Source={ConexionDB.DevolverRuta("empleados.db")}";
            Debug.WriteLine($"Ruta de la base de datos: {conexionDB}");
            optionsBuilder.UseSqlite(conexionDB);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(col => col.IdEmpleado);
                entity.Property(col => col.IdEmpleado).IsRequired().ValueGeneratedOnAdd();
            });
        }

    }
}
