namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRANSFERENCIA_INSUMOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TIN_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TIN_DataNF { get; set; }

        [Required]
        [StringLength(50)]
        public string TIN_NumeroNF { get; set; }

        public int FOR_CodigoOrigem { get; set; }

        public int FOR_CodigoDestino { get; set; }

        public decimal TIN_Quantidade { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TIN_DataTransferencia { get; set; }

        [Required]
        [StringLength(30)]
        public string TIN_NumeroLote { get; set; }

        public short SUB_Codigo { get; set; }

        public short TNF_Codigo { get; set; }

        public short TUI_Codigo { get; set; }

        public int FOR_CodigoInsumo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TIN_DataEnvio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TIN_DataMovimentacao { get; set; }

        public virtual JURIDICA JURIDICA { get; set; }

        public virtual SUBSTANCIA SUBSTANCIA { get; set; }

        public virtual TIPO_NOTAFISCAL TIPO_NOTAFISCAL { get; set; }

        public virtual TIPO_UNIDADE_INSUMO TIPO_UNIDADE_INSUMO { get; set; }
    }
}
