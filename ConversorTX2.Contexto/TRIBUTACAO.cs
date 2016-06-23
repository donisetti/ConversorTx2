namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRIBUTACAO")]
    public partial class TRIBUTACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRIBUTACAO()
        {
            PRODUTO = new HashSet<PRODUTO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TRB_Codigo { get; set; }

        [Required]
        [StringLength(30)]
        public string TRB_Descricao { get; set; }

        public decimal? TRB_AliquotaSped { get; set; }

        [StringLength(6)]
        public string trb_pct_aliquota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO> PRODUTO { get; set; }
    }
}
