//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiteProfss_v01.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facultad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facultad()
        {
            this.DepartamentosU = new HashSet<DepartamentoU>();
        }
    
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string NombreFacultad { get; set; }
        public int UniversidadId { get; set; }
    
        public virtual Universidad Universidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartamentoU> DepartamentosU { get; set; }
    }
}
