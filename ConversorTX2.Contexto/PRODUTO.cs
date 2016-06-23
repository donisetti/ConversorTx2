namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUTO")]
    public partial class PRODUTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUTO()
        {
            DEVOLUCAO_ITEM = new HashSet<DEVOLUCAO_ITEM>();
            ENTRADA_PRODUTOS = new HashSet<ENTRADA_PRODUTOS>();
            ITENS_CONSIGNADO = new HashSet<ITENS_CONSIGNADO>();
            ITENS_VENDA = new HashSet<ITENS_VENDA>();
            LOTE = new HashSet<LOTE>();
            PERDA_PRODUTOS = new HashSet<PERDA_PRODUTOS>();
            PRODUTO_INVENTARIO = new HashSet<PRODUTO_INVENTARIO>();
            SAIDA_PRODUTOS = new HashSet<SAIDA_PRODUTOS>();
            SER_COMPRA_ITEM = new HashSet<SER_COMPRA_ITEM>();
            SUBSTANCIA_PRODUTO = new HashSet<SUBSTANCIA_PRODUTO>();
            TRANSFERENCIA_PRODUTOS = new HashSet<TRANSFERENCIA_PRODUTOS>();
            VENDA_LOTE = new HashSet<VENDA_LOTE>();
        }

        [StringLength(10)]
        public string PRO_Cod_Fai { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRO_Codigo { get; set; }

        public int? PRO_Cod_Pai { get; set; }

        [StringLength(20)]
        public string PRO_Cod_Barra { get; set; }

        [Required]
        [StringLength(50)]
        public string PRO_Descricao { get; set; }

        [StringLength(50)]
        public string PRO_Apresentacao { get; set; }

        public decimal? PRO_Vlr_CustoFabrica { get; set; }

        public decimal? PRO_Vlr_CustoReal { get; set; }

        public decimal? PRO_Vlr_Venda { get; set; }

        public decimal? PRO_Vlr_CustoMedio { get; set; }

        public decimal? PRO_Vrl_CustoMedioReal { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRO_Dta_InicioDescAVista { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRO_Dta_FinalDescAVista { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRO_Dta_InicioDescAPrazo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRO_Dta_FinalDescAPrazo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRO_DataCadastro { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRO_DataAlteracao { get; set; }

        public decimal? PRO_Pct_ComissaoVista { get; set; }

        public decimal? PRO_Pct_DescAVista { get; set; }

        public decimal? PRO_Pct_DescAPrazo { get; set; }

        public decimal? PRO_Pct_ComissaoPrazo { get; set; }

        public decimal? PRO_Pct_Lucro { get; set; }

        public short? PRO_Fracao { get; set; }

        public decimal? PRO_Estoque_Minimo { get; set; }

        public decimal? PRO_Estoque_Atual { get; set; }

        [StringLength(1)]
        public string PRO_Balcao { get; set; }

        [StringLength(1)]
        public string PRO_Psicotropico { get; set; }

        [StringLength(1)]
        public string PRO_UsoContinuo { get; set; }

        [StringLength(1)]
        public string PRO_DescAVistaAtivo { get; set; }

        [StringLength(1)]
        public string PRO_DescAPrazoAtivo { get; set; }

        [StringLength(80)]
        public string PRO_Imagem { get; set; }

        public int? BUL_Codigo { get; set; }

        public short? LIN_Codigo { get; set; }

        public short? FIA_Codigo { get; set; }

        public short? CAT_Codigo { get; set; }

        public short? FAB_Codigo { get; set; }

        public short? TRB_Codigo { get; set; }

        public short? CLA_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRO_Dta_UltimaAtualizacao { get; set; }

        [StringLength(30)]
        public string PRO_CodigoRegistroMS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRO_DataExclusao { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PRO_DataDesativo { get; set; }

        [StringLength(25)]
        public string PRO_Referencia { get; set; }

        public short? UNI_Codigo { get; set; }

        public bool? PRO_Balanca { get; set; }

        public short? TIP_Codigo { get; set; }

        public bool? PRO_Psi { get; set; }

        [StringLength(8)]
        public string PRO_CodigoNCM { get; set; }

        public decimal? PRO_IpiEntrada { get; set; }

        [StringLength(200)]
        public string PRO_Aplicacao { get; set; }

        [StringLength(5)]
        public string CFOP_Codigo { get; set; }

        [StringLength(50)]
        public string PRO_InformacoesAdicionais { get; set; }

        [StringLength(4)]
        public string PRO_CodigoExcecao_NCM { get; set; }

        [StringLength(4)]
        public string STICMS_Codigo { get; set; }

        [StringLength(1)]
        public string PRO_Origem_ICMS { get; set; }

        [StringLength(4)]
        public string STIPI_Codigo { get; set; }

        [StringLength(4)]
        public string STPIS_Codigo { get; set; }

        [StringLength(4)]
        public string STCOF_Codigo { get; set; }

        public int? PRO_ValidadeProduto { get; set; }

        public short? CLAT_Codigo { get; set; }

        [StringLength(2)]
        public string PRO_TipoItem { get; set; }

        public decimal? PRO_AliqICMS { get; set; }

        public decimal? PRO_Vlr_Venda_Promocao { get; set; }

        public decimal? PRO_Vlr_Venda_Anterior { get; set; }

        public decimal? PROAliqICMS { get; set; }

        public decimal? PRO_Estoque_Reducao { get; set; }

        public decimal? PRO_RedBaseCalcICMS { get; set; }

        public virtual BULARIO BULARIO { get; set; }

        public virtual CATEGORIA CATEGORIA { get; set; }

        public virtual CLASSE_TERAPEUTICA CLASSE_TERAPEUTICA { get; set; }

        public virtual CLASSIFICACAO CLASSIFICACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEVOLUCAO_ITEM> DEVOLUCAO_ITEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTRADA_PRODUTOS> ENTRADA_PRODUTOS { get; set; }

        public virtual FABRICANTE FABRICANTE { get; set; }

        public virtual FABRICANTE FABRICANTE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITENS_CONSIGNADO> ITENS_CONSIGNADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITENS_VENDA> ITENS_VENDA { get; set; }

        public virtual LINHA_PRODUTO LINHA_PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOTE> LOTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERDA_PRODUTOS> PERDA_PRODUTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_INVENTARIO> PRODUTO_INVENTARIO { get; set; }

        public virtual TIPO_PRODUTO TIPO_PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAIDA_PRODUTOS> SAIDA_PRODUTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_COMPRA_ITEM> SER_COMPRA_ITEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUBSTANCIA_PRODUTO> SUBSTANCIA_PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFERENCIA_PRODUTOS> TRANSFERENCIA_PRODUTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_LOTE> VENDA_LOTE { get; set; }

        public virtual TRIBUTACAO TRIBUTACAO { get; set; }
    }
}
