namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConsultaVendas
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IVD_Codigo { get; set; }

        public decimal? IVD_RedBaseCalcICMS { get; set; }

        public bool? IVD_Status { get; set; }

        [StringLength(10)]
        public string IVD_MsgAdicionais { get; set; }

        [StringLength(10)]
        public string IVD_CFOP { get; set; }

        [StringLength(10)]
        public string IVD_STCOFINS { get; set; }

        [StringLength(10)]
        public string IVD_STPIS { get; set; }

        [StringLength(10)]
        public string IVD_STIPI { get; set; }

        [StringLength(10)]
        public string IVD_Origem_ICMS { get; set; }

        [StringLength(10)]
        public string IVD_STICMS { get; set; }

        [StringLength(10)]
        public string IVD_CodExcecao_NCM { get; set; }

        [StringLength(10)]
        public string IVD_CodigoNCM { get; set; }

        public int? SERPAR_Codigo { get; set; }

        public short? FUN_Codigo { get; set; }

        [StringLength(100)]
        public string IVD_Historico { get; set; }

        public int? CON_Codigo { get; set; }

        public short? TPV_Codigo { get; set; }

        [StringLength(50)]
        public string PRO_Apresentacao { get; set; }

        [StringLength(50)]
        public string PRO_Descricao { get; set; }

        public int? USU_Codigo_DescontoProduto { get; set; }

        public int? USU_Codigo { get; set; }

        public short? TRI_Codigo { get; set; }

        public short? CAT_Codigo { get; set; }

        public short? LIN_Codigo { get; set; }

        public short? CLA_Codigo { get; set; }

        public short? FAB_Codigo { get; set; }

        public int? PRO_Codigo { get; set; }

        public decimal? IVD_PctDescontoTotal { get; set; }

        public decimal? IVD_PctDescontoProduto { get; set; }

        public decimal? IVD_ValorDescontoDevolvido { get; set; }

        public decimal? IVD_ValorDevolvido { get; set; }

        public decimal? IVD_QuantidadeEstorno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? IVD_DataEstorno { get; set; }

        public decimal? IVD_PctComissao { get; set; }

        public decimal? IVD_ComissaoPaga { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? IVD_DataVencimento { get; set; }

        [StringLength(15)]
        public string IVD_Lote { get; set; }

        public decimal? IVD_ValorVendaFinal { get; set; }

        public decimal? IVD_ValorDescontoItemDevolucao { get; set; }

        public decimal? IVD_ValorDescontoProduto { get; set; }

        public decimal? IVD_ValorVendaUnitario { get; set; }

        public decimal? IVD_CustoFabrica { get; set; }

        public decimal? IVD_CustoReal { get; set; }

        public decimal? IVD_Quantidade { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long VDA_Codigo { get; set; }

        public long? Expr1 { get; set; }

        public long? ORC_Codigo { get; set; }

        [StringLength(3)]
        public string VDA_Status { get; set; }

        public int? VDA_NumeroNFe { get; set; }

        [StringLength(1)]
        public string VDA_SituacaoEnvio { get; set; }

        public int? VDA_NumeroPedido { get; set; }

        public decimal? VDA_ValorHaver { get; set; }

        public int? SER_Codigo { get; set; }

        public short? Expr2 { get; set; }

        public short? EMP_Codigo { get; set; }

        public bool? VDA_PossuiEstorno { get; set; }

        [StringLength(1)]
        public string VDA_ControlaEntrega { get; set; }

        [StringLength(50)]
        public string VDA_NomeCliente { get; set; }

        public decimal? VDA_PctDescontoTotal { get; set; }

        public short? VDA_UsuarioEstorno { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VDA_DataEstorno { get; set; }

        public int? PES_CODIGO { get; set; }

        public short? USR_UsuarioSistema { get; set; }

        public short? VDA_CodigoVendedor { get; set; }

        public decimal? VDA_ValorDescontoDevolucao { get; set; }

        public decimal? VDA_ValorDevolvido { get; set; }

        public short? VDA_NumeroECF { get; set; }

        public short? VDA_Parcelas { get; set; }

        public decimal? VDA_DescontoTotal { get; set; }

        public decimal? VDA_Valor { get; set; }

        public long? VDA_Cupom { get; set; }

        [StringLength(40)]
        public string VDA_Historico { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VDA_DataLancamento { get; set; }
    }
}
