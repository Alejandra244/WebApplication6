//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pelicula
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pelicula()
        {
            this.Genero_Pelicula = new HashSet<Genero_Pelicula>();
            this.Horario = new HashSet<Horario>();
            this.Pelicula_Protagonista = new HashSet<Pelicula_Protagonista>();
        }
    
        public int id_pelicula { get; set; }
        public string titulo_pelicula { get; set; }
        public string nombre_director { get; set; }
        public Nullable<int> id_clasificacion { get; set; }
    
        public virtual Clasificacion Clasificacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Genero_Pelicula> Genero_Pelicula { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horario> Horario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pelicula_Protagonista> Pelicula_Protagonista { get; set; }
    }
}
