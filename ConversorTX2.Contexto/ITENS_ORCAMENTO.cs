namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ITENS_ORCAMENTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IOC_Codigo { get; set; }

        public long ORC_Codigo { get; set; }

        public decimal IOC_Quantidade { get; set; }

        public decimal IOC_QuantidadeEstorno { get; set; }

        public decimal IOC_CustoFabrica { get; set; }

        public decimal IOC_ValorVendaUnitario { get; set; }

        public decimal IOC_ValorDescontoProduto { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime IOC_DataEstorno { get; set; }

        public int PRO_Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string IOC_Descricao { get; set; }

        [Required]
        [StringLength(50)]
        public string IOC_Apresentacao { get; set; }
    }
}
