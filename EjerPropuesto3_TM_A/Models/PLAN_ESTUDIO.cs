namespace EjerPropuesto3_TM_A.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PLAN_ESTUDIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLAN_ESTUDIO()
        {
            CURSO = new HashSet<CURSO>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string NOMBRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CURSO> CURSO { get; set; }
    }
}
