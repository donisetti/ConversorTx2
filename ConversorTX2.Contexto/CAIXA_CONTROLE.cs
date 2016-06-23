namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAIXA_CONTROLE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CXC_Codigo { get; set; }

        public decimal? CXC_ValorEntrada { get; set; }

        public decimal? CXC_SaldoInicial { get; set; }

        public decimal? CXC_SaldoFinal { get; set; }

        public DateTime? CXC_DataAbertura { get; set; }

        public DateTime? CXC_HoraAbertura { get; set; }

        public DateTime? CXC_DataFechamento { get; set; }

        public DateTime? CXC_HoraFechamento { get; set; }

        public decimal? CXC_SaldoMovimentacao { get; set; }

        public decimal? CXC_SaldoContasReceber { get; set; }

        public short? EMP_Codigo { get; set; }
    }
}
