using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.entities.Entity
{
    public class EntityGrupo 
    {
        public int ID { get; set; }
        public Nullable<int> Grupo { get; set; }
        [DisplayName("Nombre del Profesor")]
        public string profesor { get; set; }
        [DisplayName("Cantidad de Alumnos")]
        public int Cantidad_Alum { get; set; }

    }
}
