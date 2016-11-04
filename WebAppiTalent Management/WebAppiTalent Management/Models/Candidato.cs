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
    
    public partial class Candidato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Candidato()
        {
            this.AsignacionVacante = new HashSet<AsignacionVacante>();
        }
    
        public int CandidatoId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Nullable<int> LocalidadId { get; set; }
        public Nullable<int> SueldoId { get; set; }
        public Nullable<int> EscolaridadId { get; set; }
        public Nullable<int> EspecialidadId { get; set; }
        public Nullable<bool> EstadoCandidato { get; set; }
        public string Capturista { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public string Archivo { get; set; }
        public string Municipio_colonia { get; set; }
        public Nullable<int> EstatusId { get; set; }
        public string ComentarioEstatus { get; set; }
        public string Area { get; set; }
        public Nullable<int> EmpresaId { get; set; }
    
        public virtual Empresa Empresa { get; set; }
        public virtual Escolaridad Escolaridad { get; set; }
        public virtual Especialidad Especialidad { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual Localidad Localidad { get; set; }
        public virtual Sueldo Sueldo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsignacionVacante> AsignacionVacante { get; set; }
    }
}
