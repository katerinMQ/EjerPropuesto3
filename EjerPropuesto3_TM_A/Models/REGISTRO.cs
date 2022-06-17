namespace EjerPropuesto3_TM_A.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REGISTRO")]
    public partial class REGISTRO
    {
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string CODIGO { get; set; }

        public int? IDRESULTADO { get; set; }

        public virtual RESULTADO RESULTADO { get; set; }
    }
}
