namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORMA_PAGAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORMA_PAGAMENTO()
        {
            FORMA_PAGAMENTO_IMPRESSORA = new HashSet<FORMA_PAGAMENTO_IMPRESSORA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FPG_Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string FPG_Descricao { get; set; }

        public int? PCT_CodigoReduzido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMA_PAGAMENTO_IMPRESSORA> FORMA_PAGAMENTO_IMPRESSORA { get; set; }

        public virtual PLANO_CONTAS PLANO_CONTAS { get; set; }
    }
}
