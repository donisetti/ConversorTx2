namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UNIDADE_MEDIDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UNIDADE_MEDIDA()
        {
            ENTRADA_UNIDADE_MEDIDA = new HashSet<ENTRADA_UNIDADE_MEDIDA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short UNI_Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string UNI_Descricao { get; set; }

        [Required]
        [StringLength(3)]
        public string UNI_Sigla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTRADA_UNIDADE_MEDIDA> ENTRADA_UNIDADE_MEDIDA { get; set; }
    }
}
