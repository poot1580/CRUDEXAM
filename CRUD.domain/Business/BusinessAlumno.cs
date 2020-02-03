using CRUD.data.Repository;
using CRUD.entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.domain.Business
{
    public class BusinessAlumno
    {
        public List<EntityAlumno> Getall()
        {
            return new RepositoryAlumno().GetAll();
        }
        public EntityAlumno GetByID(int id)
        {
            return new RepositoryAlumno().GetByID(id);
        }



        public EntityAlumno Insert(EntityAlumno model)
        {

            EntityAlumno data = new EntityAlumno()
            {
                NombreA=model.NombreA,
                Edad=model.Edad,
                Fecha_Nac=model.Fecha_Nac,
                Grupo=model.Grupo,
                Padre=model.Padre,
                profesor=model.profesor
               
            };

            data = new RepositoryAlumno().Insert(data);
           

            return model;
        }

        public EntityAlumno Update(EntityAlumno model)
        {
            EntityAlumno data = new EntityAlumno()
            {
                ID=model.ID,
                NombreA = model.NombreA,
                Edad = model.Edad,
                Fecha_Nac = model.Fecha_Nac,
                Grupo = model.Grupo,
                Padre = model.Padre,
                profesor = model.profesor
            };

            data = new RepositoryAlumno().Update(data);
            return model;
        }

        public  void BorrarAlumno(int Id)
        {
            new RepositoryAlumno().delete(Id);
        }
    }
}
