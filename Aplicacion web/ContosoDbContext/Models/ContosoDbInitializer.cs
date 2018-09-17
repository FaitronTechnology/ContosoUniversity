using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContosoDbContext.Models
{
    public class ContosoDbInitializer:DropCreateDatabaseIfModelChanges<ContosoDbContext>
    {
        protected override void Seed(ContosoDbContext context)
        {
            List<Student> Students = new List<Student>();
            Students.Add(new Student() { LastName= "Mendez", FirstName="Fabian", EnrollomentDate = DateTime.Now});
            Students.Add(new Student() { LastName = "Castillo", FirstName = "Horacio", EnrollomentDate = DateTime.Now });
            Students.Add(new Student() { LastName = "Ruben", FirstName = "Escobar", EnrollomentDate = DateTime.Now });
            Students.Add(new Student() { LastName = "Vicente", FirstName = "Garcia", EnrollomentDate = DateTime.Now });
            
            //Insertar en la base de datos.
            context.Students.AddRange(Students);
            context.SaveChanges();

            List<Course> Courses = new List<Course>();
            Courses.Add(new Course() { Title = "Programacion", Credits = 3 });
            Courses.Add(new Course() { Title = "Ingles", Credits = 5 });
            Courses.Add(new Course() { Title = "Base de datos", Credits = 7 });
            Courses.Add(new Course() { Title = "Ing.Software", Credits = 4 });

            //Insertar en la base de datos.
            context.Courses.AddRange(Courses);
            context.SaveChanges();

        }
    }
}