//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppiTalent_Management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VacanteSueldo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VacanteSueldo()
        {
            this.Vacante = new HashSet<Vacante>();
        }
    
        public int VacanteSueldoId { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacante> Vacante { get; set; }
    }
}
