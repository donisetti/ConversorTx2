namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUTO_INVENTARIO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRO_Codigo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string PRO_Lote { get; set; }

        public short PRO_Quantidade { get; set; }

        public short? PRO_EstoqueInicial { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRO_DataEntradaInventario { get; set; }

        [StringLength(13)]
        public string PRO_RegistroMSInventario { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
