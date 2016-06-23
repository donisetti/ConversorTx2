namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESTOQUE_CLIENTE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IVD_Codigo { get; set; }

        public long VDA_Codigo { get; set; }

        public decimal ECL_QuantidadeEntregue { get; set; }

        public int PRO_Codigo { get; set; }
    }
}
