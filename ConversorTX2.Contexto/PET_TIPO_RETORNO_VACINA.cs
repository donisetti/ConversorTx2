namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PET_TIPO_RETORNO_VACINA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PET_TIPO_RETORNO_VACINA()
        {
            PET_VACINA = new HashSet<PET_VACINA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TRV_Codigo { get; set; }

        [StringLength(10)]
        public string TRV_Retorno { get; set; }

        [StringLength(5)]
        public string TRV_Dias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PET_VACINA> PET_VACINA { get; set; }
    }
}
