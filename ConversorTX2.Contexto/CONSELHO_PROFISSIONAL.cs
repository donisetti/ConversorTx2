namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONSELHO_PROFISSIONAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONSELHO_PROFISSIONAL()
        {
            MEDICOS = new HashSet<MEDICOS>();
        }

        [Key]
        [StringLength(20)]
        public string CAL_Sigla { get; set; }

        [Required]
        [StringLength(100)]
        public string CAL_Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEDICOS> MEDICOS { get; set; }
    }
}
