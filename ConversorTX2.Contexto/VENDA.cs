namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENDA")]
    public partial class VENDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDA()
        {
            CHEQUE = new HashSet<CHEQUE>();
            CONTAS_RECEBER = new HashSet<CONTAS_RECEBER>();
            DEVOLUCAO = new HashSet<DEVOLUCAO>();
            ENDERECO_ENTREGA = new HashSet<ENDERECO_ENTREGA>();
            ITENS_CONSIGNADO = new HashSet<ITENS_CONSIGNADO>();
            ITENS_VENDA = new HashSet<ITENS_VENDA>();
            NFe_NOTA_CUPOM = new HashSet<NFe_NOTA_CUPOM>();
            VENDA_PAGAMENTO = new HashSet<VENDA_PAGAMENTO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long VDA_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime VDA_DataLancamento { get; set; }

        [StringLength(40)]
        public string VDA_Historico { get; set; }

        public long? VDA_Cupom { get; set; }

        public decimal? VDA_Valor { get; set; }

        public decimal? VDA_DescontoTotal { get; set; }

        public short? VDA_Parcelas { get; set; }

        public short? VDA_NumeroECF { get; set; }

        public decimal? VDA_ValorDevolvido { get; set; }

        public decimal? VDA_ValorDescontoDevolucao { get; set; }

        public short VDA_CodigoVendedor { get; set; }

        public short? USR_UsuarioSistema { get; set; }

        public int PES_CODIGO { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VDA_DataEstorno { get; set; }

        public short? VDA_UsuarioEstorno { get; set; }

        public decimal? VDA_PctDescontoTotal { get; set; }

        [StringLength(50)]
        public string VDA_NomeCliente { get; set; }

        [StringLength(1)]
        public string VDA_ControlaEntrega { get; set; }

        public bool VDA_PossuiEstorno { get; set; }

        public short? EMP_Codigo { get; set; }

        public short? TPV_Codigo { get; set; }

        public int? SER_Codigo { get; set; }

        public decimal? VDA_ValorHaver { get; set; }

        public int? VDA_NumeroPedido { get; set; }

        [StringLength(1)]
        public string VDA_SituacaoEnvio { get; set; }

        public int? VDA_NumeroNFe { get; set; }

        [StringLength(3)]
        public string VDA_Status { get; set; }

        public long? ORC_Codigo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHEQUE> CHEQUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTAS_RECEBER> CONTAS_RECEBER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEVOLUCAO> DEVOLUCAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENDERECO_ENTREGA> ENDERECO_ENTREGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITENS_CONSIGNADO> ITENS_CONSIGNADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITENS_VENDA> ITENS_VENDA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_NOTA_CUPOM> NFe_NOTA_CUPOM { get; set; }

        public virtual ORCAMENTO ORCAMENTO { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        public virtual SER_SERVICO SER_SERVICO { get; set; }

        public virtual TIPO_VENDA TIPO_VENDA { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_PAGAMENTO> VENDA_PAGAMENTO { get; set; }
    }
}
