//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD.data.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumnos
    {
        public int ID { get; set; }
        public string Nombre_Alum { get; set; }
        public Nullable<int> Edad { get; set; }
        public Nullable<System.DateTime> Fecha_de_Nacimiento { get; set; }
        public Nullable<int> Grupo { get; set; }
        public string Tutor { get; set; }
        public string Profesor { get; set; }
    }
}
