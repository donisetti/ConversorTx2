namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_COMPRA_ITEM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COI_Codigo { get; set; }

        public decimal? COI_Quantidade { get; set; }

        public decimal? COI_ValorCustoCompra { get; set; }

        public int? COM_Codigo { get; set; }

        public int? PRO_Codigo { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual SER_COMPRA SER_COMPRA { get; set; }
    }
}
