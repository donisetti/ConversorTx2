namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAIDA_PRODUTOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SPR_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SPR_DataVenda { get; set; }

        [Required]
        [StringLength(20)]
        public string SPR_NumeroReceita { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SPR_DataReceita { get; set; }

        [Required]
        [StringLength(30)]
        public string SPR_NumeroLote { get; set; }

        public short SPR_Quantidade { get; set; }

        public int PRO_Codigo { get; set; }

        public short TUM_Codigo { get; set; }

        public short TDO_Codigo { get; set; }

        public int MED_Codigo { get; set; }

        public short TIO_Codigo { get; set; }

        public int PCLI_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SPR_DataEnvio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SPR_DataMovimentacao { get; set; }

        [StringLength(13)]
        public string PRO_RegistroMsInventario { get; set; }

        public virtual MEDICOS MEDICOS { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual PSICO_CLIENTE PSICO_CLIENTE { get; set; }

        public virtual TIPO_DOCUMENTOS TIPO_DOCUMENTOS { get; set; }

        public virtual TIPO_RECEITUARIO TIPO_RECEITUARIO { get; set; }

        public virtual TIPO_USO_MEDICAMENTO TIPO_USO_MEDICAMENTO { get; set; }
    }
}
