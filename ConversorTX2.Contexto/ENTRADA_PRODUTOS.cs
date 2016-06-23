namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENTRADA_PRODUTOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ENT_Codigo { get; set; }

        [Required]
        [StringLength(20)]
        public string ENT_NumeroNF { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ENT_DataNF { get; set; }

        [Required]
        [StringLength(30)]
        public string ENT_NumeroLote { get; set; }

        public short ENT_Quantidade { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ENT_DataRecebimento { get; set; }

        public int FOR_CodigoProduto { get; set; }

        public int FOR_CodigoDestino { get; set; }

        public int PRO_Codigo { get; set; }

        public short TNF_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ENT_DataEnvio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ENT_DataMovimentacao { get; set; }

        [StringLength(13)]
        public string PRO_RegistroMsInventario { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual TIPO_NOTAFISCAL TIPO_NOTAFISCAL { get; set; }
    }
}
