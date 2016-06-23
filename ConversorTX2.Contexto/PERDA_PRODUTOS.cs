namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERDA_PRODUTOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PPR_Codigo { get; set; }

        [Required]
        [StringLength(30)]
        public string PPR_NumeroLote { get; set; }

        public short PPR_Quantidade { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PPR_DataPerda { get; set; }

        public short TMP_Codigo { get; set; }

        public int PRO_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PPR_DataEnvio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PPR_DataMovimentacao { get; set; }

        [StringLength(13)]
        public string PRO_RegistroMsInventario { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual TIPO_MOTIVO_PERDA TIPO_MOTIVO_PERDA { get; set; }
    }
}
