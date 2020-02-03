using CRUD.data.Factory;
using CRUD.data.model;
using CRUD.entities.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.data.Repository
{
    public class RepositoryAlumno: BaseRepository
    {
        public List<EntityAlumno> GetAll()
        {
            return FactoryAlumno.GetList(base.DataContext.Alumnos.ToList());
                
        }
        public EntityAlumno GetByID(int id)
        {
            var data = base.DataContext.Alumnos.Where(p => p.ID == id);
            if (data.Count() == 1)
                return FactoryAlumno.Get(data.Single());
            else
                return null;
           
        }

        public EntityAlumno Insert(EntityAlumno data)
        {
            try
            {
                Alumnos dataNew = new Alumnos()
                {
                    Nombre_Alum=data.NombreA,
                    Edad=data.Edad,
                    Fecha_de_Nacimiento=data.Fecha_Nac,
                    Grupo=data.Grupo,
                    Tutor=data.Padre,
                    Profesor=data.profesor,
                };
                base.DataContext.Alumnos.Add(dataNew);
                base.DataContext.SaveChanges();

                data.ID = dataNew.ID;

                return data;
            }
            catch (DbException dbex)
            {
                throw dbex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public EntityAlumno Update(EntityAlumno data)
        {
            try
            {
                var dataUpdate = base.DataContext.Alumnos.Where(p => p.ID == data.ID).SingleOrDefault();

                if (dataUpdate != null)
                {

                    dataUpdate.ID = data.ID;
                    dataUpdate.Nombre_Alum = data.NombreA;
                    dataUpdate.Fecha_de_Nacimiento = data.Fecha_Nac;
                    dataUpdate.Edad = data.Edad;
                    dataUpdate.Grupo = data.Grupo;
                    dataUpdate.Tutor = data.Padre;
                    dataUpdate.Profesor = data.profesor;
                    

                    base.DataContext.Entry(dataUpdate).State = EntityState.Modified;
                    base.DataContext.SaveChanges();
                }
                else
                {
                    throw new Exception("No se encontró el registro en la base de datos a modificar.");
                }

                return data;
            }
            catch (DbException dbex)
            {
                throw dbex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete(int Id)
        {
            try
            {

                Alumnos alumno = base.DataContext.Alumnos.Find(Id);
                base.DataContext.Alumnos.Remove(alumno);
               base.DataContext.SaveChanges();

               

                return ;
            }
            catch (DbException dbex)
            {
                throw dbex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
