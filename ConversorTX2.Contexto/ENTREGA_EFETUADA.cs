namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENTREGA_EFETUADA
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IVD_Codigo { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime EFE_DataEntrega { get; set; }

        public int PES_Codigo { get; set; }

        public decimal EFE_QuantidadeEntregue { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
