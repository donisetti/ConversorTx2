namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRANSFERENCIA_PRODUTOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TPR_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TPR_DataNF { get; set; }

        [Required]
        [StringLength(10)]
        public string TPR_NumeroNF { get; set; }

        public int FOR_CodigoOrigem { get; set; }

        public int FOR_CodigoDestino { get; set; }

        public short TPR_Quantidade { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TPR_DataTransferencia { get; set; }

        [Required]
        [StringLength(30)]
        public string TPR_NumeroLote { get; set; }

        public int PRO_Codigo { get; set; }

        public short TNF_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TPR_DataEnvio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TPR_DataMovimentacao { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual TIPO_NOTAFISCAL TIPO_NOTAFISCAL { get; set; }
    }
}
