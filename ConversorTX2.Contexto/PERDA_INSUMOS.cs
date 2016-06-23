namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERDA_INSUMOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PIN_Codigo { get; set; }

        [Required]
        [StringLength(30)]
        public string PIN_NumeroLote { get; set; }

        public decimal PIN_Quantidade { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PIN_DataPerda { get; set; }

        public int FOR_CodigoInsumo { get; set; }

        public short SUB_Codigo { get; set; }

        public short TMP_Codigo { get; set; }

        public short TUI_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PIN_DataEnvio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PIN_DataMovimentacao { get; set; }

        public virtual JURIDICA JURIDICA { get; set; }

        public virtual SUBSTANCIA SUBSTANCIA { get; set; }

        public virtual TIPO_MOTIVO_PERDA TIPO_MOTIVO_PERDA { get; set; }

        public virtual TIPO_UNIDADE_INSUMO TIPO_UNIDADE_INSUMO { get; set; }
    }
}
