using CRUD.data.model;
using CRUD.entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.data.Factory
{
     internal class FactoryAlumno:BaseFactory<FactoryAlumno,EntityAlumno,Alumnos>
    {
        public override EntityAlumno _GetEntity(Alumnos entidad)
        {
            return new EntityAlumno()
            {
               ID=entidad.ID,
              NombreA=entidad.Nombre_Alum,
              Edad=entidad.Edad,
              Fecha_Nac=entidad.Fecha_de_Nacimiento,
              Grupo=entidad.Grupo,
              Padre=entidad.Tutor,
              profesor=entidad.Profesor
            };
        }

    }
}
