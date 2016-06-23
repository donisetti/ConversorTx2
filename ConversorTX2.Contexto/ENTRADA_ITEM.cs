namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENTRADA_ITEM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ETI_Codigo { get; set; }

        public decimal ETI_Quantidade { get; set; }

        public int? ENT_Codigo { get; set; }

        public int? PRO_Codigo { get; set; }

        public decimal? ETI_ValorCusto { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ETI_DataEntrada { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LOT_DataVencimento { get; set; }

        public decimal? ETI_IpiEntrada { get; set; }

        public decimal? ETI_ValorFreteUnitario { get; set; }

        [StringLength(4)]
        public string STICMS_Codigo { get; set; }

        [StringLength(5)]
        public string CFOP_Codigo { get; set; }

        public decimal? ETI_AliqICMS { get; set; }

        public decimal? ETI_BaseCalcICMS { get; set; }

        public decimal? ETI_ValorICMS { get; set; }

        public short? UNI_Codigo { get; set; }

        public decimal? ETI_AliqICMSST { get; set; }

        [StringLength(4)]
        public string STIPI_Codigo { get; set; }

        public decimal? ETI_BaseCalcIPI { get; set; }

        public decimal? ETI_AliqIPI { get; set; }

        public decimal? ETI_ValorIPI { get; set; }

        [StringLength(4)]
        public string STPIS_Codigo { get; set; }

        public decimal? ETI_BaseCalcPIS { get; set; }

        public decimal? ETI_ValorPIS { get; set; }

        public decimal? ETI_AliqPIS { get; set; }

        [StringLength(4)]
        public string STCOFINS_Codigo { get; set; }

        public decimal? ETI_BaseCalcCOFINS { get; set; }

        public decimal? ETI_AliqCOFINS { get; set; }

        public decimal? ETI_ValorCOFINS { get; set; }

        public decimal? ETI_BaseCalcICMSST { get; set; }

        public decimal? ETI_ValorICMSST { get; set; }

        public decimal? ETI_ValorDesconto { get; set; }

        public decimal? ETI_ValorTotal { get; set; }

        public decimal? ETI_ValorOutrasDespesas { get; set; }
    }
}
