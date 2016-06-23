namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PET_VACINA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PET_VACINA()
        {
            PET_VACINACAO = new HashSet<PET_VACINACAO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short VAC_Codigo { get; set; }

        [StringLength(50)]
        public string VAC_Descricao { get; set; }

        [StringLength(2)]
        public string VAC_Doses { get; set; }

        public short? TRV_Codigo { get; set; }

        public int? PRO_Codigo { get; set; }

        [StringLength(50)]
        public string VAC_ProximaVacina { get; set; }

        public virtual PET_TIPO_RETORNO_VACINA PET_TIPO_RETORNO_VACINA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PET_VACINACAO> PET_VACINACAO { get; set; }
    }
}
