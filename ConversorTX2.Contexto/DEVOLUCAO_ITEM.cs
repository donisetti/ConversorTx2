namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEVOLUCAO_ITEM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DVI_Codigo { get; set; }

        public int? DEV_Codigo { get; set; }

        public decimal? DVI_Quantidade { get; set; }

        public decimal? DVI_ValorUnitario { get; set; }

        public decimal? DVI_DescontoItemPct { get; set; }

        public int? PRO_Codigo { get; set; }

        public virtual DEVOLUCAO DEVOLUCAO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
