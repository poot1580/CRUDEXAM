using CRUD.domain.Business;
using CRUD.entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.domain.Facade
{
     public class FacadeAlumno
    {
        public static List<EntityAlumno> GetAll()
        {
            return new BusinessAlumno().Getall();
        }

        public static EntityAlumno GetByID(int Id)
        {
            return new BusinessAlumno().GetByID(Id);
        }

        public static EntityAlumno insertalumno (EntityAlumno alumno)
        {
            return new BusinessAlumno().Insert(alumno);
        }

        public static void DeleteAlum(int id)
        {
            new BusinessAlumno().BorrarAlumno(id);
        }

        public static EntityAlumno Update(EntityAlumno alumno)
        {
           return new BusinessAlumno().Update(alumno);

        }

    }
}
