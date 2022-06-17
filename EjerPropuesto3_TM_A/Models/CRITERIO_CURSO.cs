namespace EjerPropuesto3_TM_A.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRITERIO_CURSO
    {
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string CODIGO { get; set; }

        public int IDCRITERIO { get; set; }

        public int IDCURSO { get; set; }

        public int PORCENTAJEASIGNADO { get; set; }

        public decimal PORCENTAJEOBTENIDO { get; set; }

        public virtual CRITERIO CRITERIO { get; set; }

        public virtual CURSO CURSO { get; set; }
    }
}
