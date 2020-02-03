using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.entities.Entity
{
    public class EntityAlumno:EntityGrupo
    {
        public int ID { get; set;}
        [DisplayName("Nombre del Alumno")]
        public string NombreA { get; set; }
        [DisplayName("Edad")]
        public Nullable<int> Edad { get; set; }
        [DisplayName("Fecha de Nacimiento")]
        public Nullable<DateTime> Fecha_Nac { get; set; }
        [DisplayName("Padre o Tutor")]
        public string Padre { get; set; }
        


    }
}
