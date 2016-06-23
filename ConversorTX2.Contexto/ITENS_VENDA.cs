namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ITENS_VENDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IVD_Codigo { get; set; }

        public long VDA_Codigo { get; set; }

        public decimal? IVD_Quantidade { get; set; }

        public decimal? IVD_CustoReal { get; set; }

        public decimal? IVD_CustoFabrica { get; set; }

        public decimal? IVD_ValorVendaUnitario { get; set; }

        public decimal? IVD_ValorDescontoProduto { get; set; }

        public decimal? IVD_ValorDescontoItemDevolucao { get; set; }

        public decimal? IVD_ValorVendaFinal { get; set; }

        [StringLength(15)]
        public string IVD_Lote { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? IVD_DataVencimento { get; set; }

        public decimal? IVD_ComissaoPaga { get; set; }

        public decimal? IVD_PctComissao { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? IVD_DataEstorno { get; set; }

        public decimal? IVD_QuantidadeEstorno { get; set; }

        public decimal? IVD_ValorDevolvido { get; set; }

        public decimal? IVD_ValorDescontoDevolvido { get; set; }

        public decimal? IVD_PctDescontoProduto { get; set; }

        public decimal? IVD_PctDescontoTotal { get; set; }

        public int? PRO_Codigo { get; set; }

        public short? FAB_Codigo { get; set; }

        public short? CLA_Codigo { get; set; }

        public short? LIN_Codigo { get; set; }

        public short? CAT_Codigo { get; set; }

        public short? TRI_Codigo { get; set; }

        public int? USU_Codigo { get; set; }

        public int? USU_Codigo_DescontoProduto { get; set; }

        [StringLength(50)]
        public string PRO_Descricao { get; set; }

        [StringLength(50)]
        public string PRO_Apresentacao { get; set; }

        public short? TPV_Codigo { get; set; }

        public int? CON_Codigo { get; set; }

        [StringLength(100)]
        public string IVD_Historico { get; set; }

        public short? FUN_Codigo { get; set; }

        public int? SERPAR_Codigo { get; set; }

        [StringLength(10)]
        public string IVD_CodigoNCM { get; set; }

        [StringLength(10)]
        public string IVD_CodExcecao_NCM { get; set; }

        [StringLength(10)]
        public string IVD_STICMS { get; set; }

        [StringLength(10)]
        public string IVD_Origem_ICMS { get; set; }

        [StringLength(10)]
        public string IVD_STIPI { get; set; }

        [StringLength(10)]
        public string IVD_STPIS { get; set; }

        [StringLength(10)]
        public string IVD_STCOFINS { get; set; }

        [StringLength(10)]
        public string IVD_CFOP { get; set; }

        [StringLength(10)]
        public string IVD_MsgAdicionais { get; set; }

        public bool? IVD_Status { get; set; }

        public decimal? IVD_RedBaseCalcICMS { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual SER_FUNCIONARIO SER_FUNCIONARIO { get; set; }

        public virtual SER_SERVICO_PARTE SER_SERVICO_PARTE { get; set; }

        public virtual TIPO_VENDA TIPO_VENDA { get; set; }

        public virtual VENDA VENDA { get; set; }
    }
}
