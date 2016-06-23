namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTAS_RECEBIMENTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long COR_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? COR_DataRecebimento { get; set; }

        public decimal? COR_ValorRecebido { get; set; }

        public decimal? COR_ValorJurosRecebidos { get; set; }

        public decimal? COR_ValorDesconto { get; set; }

        public decimal? COR_ValorAbatido { get; set; }

        public decimal? COR_JuroAbatido { get; set; }

        public decimal? COR_JuroRestante { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? COR_DataAbatido { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? COR_DataEstorno { get; set; }

        public int? USU_Codigo { get; set; }

        public int CRE_Codigo { get; set; }

        public DateTime? COR_DataLancamento { get; set; }

        public virtual CONTAS_RECEBER CONTAS_RECEBER { get; set; }
    }
}
