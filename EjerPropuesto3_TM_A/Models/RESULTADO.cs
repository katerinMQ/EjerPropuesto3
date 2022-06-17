namespace EjerPropuesto3_TM_A.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;

    [Table("RESULTADO")]
    public partial class RESULTADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESULTADO()
        {
            CRITERIO = new HashSet<CRITERIO>();
            REGISTRO = new HashSet<REGISTRO>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string NOMBRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRITERIO> CRITERIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTRO> REGISTRO { get; set; }

        //Implementar m?todos

        //M?todo Listar
        public List<RESULTADO> Listar()
        {
            var query = new List<RESULTADO>();
            try
            {
                using (var db = new ModeloEjercicio3())
                {
                    query = db.RESULTADO.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return query;
        }

        //Metodo obtener
        public RESULTADO Obtener(int id) //Retornar objeto
        {
            var query = new RESULTADO();
            try
            {
                using (var db = new ModeloEjercicio3())
                {
                    query = db.RESULTADO
                        .Where(x => x.ID == id)
                        .SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return query;
        }

        //Metodo obtener criterio
        public List<RESULTADO> ObtenerCantidadCriterio()
        {
            var objResultado = new List<RESULTADO>();
            try
            {
                using (var db = new ModeloEjercicio3())
                {
                    objResultado = db.RESULTADO
                        .Include("CRITERIO")
                        .ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return objResultado;
        }
    }
}
