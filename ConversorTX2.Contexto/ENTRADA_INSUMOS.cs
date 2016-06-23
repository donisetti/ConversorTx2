namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENTRADA_INSUMOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EIS_Codigo { get; set; }

        [Required]
        [StringLength(20)]
        public string EIS_NumeroNF { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EIS_DataNF { get; set; }

        [Required]
        [StringLength(30)]
        public string EIS_NumeroLote { get; set; }

        public decimal EIS_Quantidade { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EIS_DataRecebimento { get; set; }

        public int FOR_CodigoOrigem { get; set; }

        public int FOR_CodigoDestino { get; set; }

        public int FOR_CodigoInsumo { get; set; }

        public short SUB_Codigo { get; set; }

        public short TNF_Codigo { get; set; }

        public short TUI_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EIS_DataEnvio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EIS_DataMovimentacao { get; set; }

        public virtual SUBSTANCIA SUBSTANCIA { get; set; }

        public virtual TIPO_NOTAFISCAL TIPO_NOTAFISCAL { get; set; }

        public virtual TIPO_UNIDADE_INSUMO TIPO_UNIDADE_INSUMO { get; set; }
    }
}
