using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContosoDbContext.Models
{
    //context: nos sirve para indicar cuales  vamos a utilizar para communicarse con el proveeedor en este caso es el mysql
    //bug es importante que se la pongamos para que tengas una buna conexion
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ContosoDbContext:DbContext
    {
        public ContosoDbContext() : base("ContosoDbContext")
        {
            //inicializa la clase ContosoDbInitializer
            Database.SetInitializer<ContosoDbContext>(new ContosoDbInitializer());
        }

        //Debemos añadir un DbSet<> por cada una de las tablas o clasesde dominio que tengamos en la BD
        //y nuestro proyecto de BisnessEntities.
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        //sirve para configurar la pluralizacion de nuestras tablas.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Elimina la configuracion de colocar las tablas de singular a plural y viceversa.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}