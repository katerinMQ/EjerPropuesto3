namespace EjerPropuesto3_TM_A.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CURSO")]
    public partial class CURSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CURSO()
        {
            CRITERIO_CURSO = new HashSet<CRITERIO_CURSO>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(250)]
        public string CICLO { get; set; }

        public int? IDPLANESTUDIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRITERIO_CURSO> CRITERIO_CURSO { get; set; }

        public virtual PLAN_ESTUDIO PLAN_ESTUDIO { get; set; }
    }
}
