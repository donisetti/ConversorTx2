namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAIXA_LANCAMENTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CXL_Codigo { get; set; }

        public decimal? CXL_ValorLancamento { get; set; }

        public DateTime? CXL_DataLancamento { get; set; }

        public int? CXC_Codigo { get; set; }

        [StringLength(80)]
        public string CXL_Historico { get; set; }

        public long CXL_NumeroDocumento { get; set; }

        public int? PCT_CodigoReduzido { get; set; }

        public int? CXO_CODIGO { get; set; }

        public virtual CAIXA_OPERADOR CAIXA_OPERADOR { get; set; }

        public virtual PLANO_CONTAS PLANO_CONTAS { get; set; }
    }
}
