namespace EjerPropuesto3_TM_A.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRITERIO")]
    public partial class CRITERIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRITERIO()
        {
            CRITERIO_CURSO = new HashSet<CRITERIO_CURSO>();
            REGISTRO_CRITERIO = new HashSet<REGISTRO_CRITERIO>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string NOMBRE { get; set; }

        public int? IDRESULTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRITERIO_CURSO> CRITERIO_CURSO { get; set; }

        public virtual RESULTADO RESULTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTRO_CRITERIO> REGISTRO_CRITERIO { get; set; }
    }
}
