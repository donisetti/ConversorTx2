namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PLANO_CONTAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLANO_CONTAS()
        {
            CAIXA_LANCAMENTO = new HashSet<CAIXA_LANCAMENTO>();
            FORMA_PAGAMENTO = new HashSet<FORMA_PAGAMENTO>();
            FORNECEDORES = new HashSet<FORNECEDORES>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PCT_CodigoReduzido { get; set; }

        [Required]
        [StringLength(50)]
        public string PCT_CodigoConta { get; set; }

        [Required]
        [StringLength(50)]
        public string PCT_Descricao { get; set; }

        public short PCT_Grau { get; set; }

        [StringLength(1)]
        public string PCT_Conta { get; set; }

        [Required]
        [StringLength(1)]
        public string PCT_SensibilizaCaixa { get; set; }

        [StringLength(1)]
        public string PCT_ContaSistema { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAIXA_LANCAMENTO> CAIXA_LANCAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMA_PAGAMENTO> FORMA_PAGAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORNECEDORES> FORNECEDORES { get; set; }
    }
}
