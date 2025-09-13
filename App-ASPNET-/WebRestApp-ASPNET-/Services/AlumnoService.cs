using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebRestApp_ASPNET_.DbContexts;
using WebRestApp_ASPNET_.Models;

namespace WebRestApp_ASPNET_.Services
{
    public class AlumnoService
    {
        AppDbContext dbContext;
        public AlumnoService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Alumno> GetAll()
        {
            return [.. dbContext.Alumnos];
        }

        public Alumno? GetById(int id)
        {
            Alumno? a = dbContext.Alumnos.Find(id);
            return a;
        }

        public int Insert(Alumno a)
        {
            EntityEntry<Alumno> ee = dbContext.Alumnos.Add(a);
            dbContext.SaveChanges();
            return ee.Entity.Id;
        }

        public bool Update(Alumno updatedA)
        {
            bool r = false;
            Alumno? a = GetById(updatedA.Id);
            if (a != null)
            {
                a.Name = updatedA.Name;
                a.Age = updatedA.Age;
                r = dbContext.SaveChanges() > 0;
            }
            return r;
        }

        public bool Delete(int id)
        {
            bool r = false;
            Alumno? a = GetById(id);
            if (a != null)
            {
                dbContext.Alumnos.Remove(a);
                r = dbContext.SaveChanges() > 0;
            }
            return r;
        }

    }
}
