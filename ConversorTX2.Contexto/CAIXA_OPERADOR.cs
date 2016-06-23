namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAIXA_OPERADOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAIXA_OPERADOR()
        {
            CAIXA_LANCAMENTO = new HashSet<CAIXA_LANCAMENTO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CXO_Codigo { get; set; }

        public decimal? CXO_ValorEntrada { get; set; }

        public decimal? CXO_SaldoFinal { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CXO_DataEntradaOperador { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CXO_DataSaidaOperador { get; set; }

        public short? CXO_NumeroCaixa { get; set; }

        public int? CXC_Codigo { get; set; }

        public short? OPE_Codigo { get; set; }

        public short? EMP_Codigo { get; set; }

        public short? CXA_Codigo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAIXA_LANCAMENTO> CAIXA_LANCAMENTO { get; set; }
    }
}
