namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ITENS_CONSIGNADO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ICD_Codigo { get; set; }

        public long CDO_Codigo { get; set; }

        public decimal? ICD_Quantidade { get; set; }

        public decimal? ICD_QuantidadeEstorno { get; set; }

        public decimal? ICD_CustoReal { get; set; }

        public decimal? ICD_CustoFabrica { get; set; }

        public decimal? ICD_ValorVendaUnitario { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ICD_DataEstorno { get; set; }

        public int? PRO_Codigo { get; set; }

        [StringLength(50)]
        public string ICD_Descricao { get; set; }

        [StringLength(50)]
        public string ICD_Apresentacao { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ICD_DataLancamento { get; set; }

        public long VDA_Codigo { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual VENDA VENDA { get; set; }
    }
}
