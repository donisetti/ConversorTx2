namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PESSOA")]
    public partial class PESSOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PESSOA()
        {
            CHEQUE = new HashSet<CHEQUE>();
            CONSIGNADO = new HashSet<CONSIGNADO>();
            CONTAS_RECEBER = new HashSet<CONTAS_RECEBER>();
            COPS_MOVIMENTO = new HashSet<COPS_MOVIMENTO>();
            DEVOLUCAO = new HashSet<DEVOLUCAO>();
            ENDERECO_ENTREGA = new HashSet<ENDERECO_ENTREGA>();
            ENTREGA_EFETUADA = new HashSet<ENTREGA_EFETUADA>();
            NFe_INFNOTAFISCAL = new HashSet<NFe_INFNOTAFISCAL>();
            ORCAMENTO = new HashSet<ORCAMENTO>();
            PESSOA_CLASSIFICACAO = new HashSet<PESSOA_CLASSIFICACAO>();
            SER_COMPRA = new HashSet<SER_COMPRA>();
            SER_EQUIPAMENTO = new HashSet<SER_EQUIPAMENTO>();
            SER_SERVICO = new HashSet<SER_SERVICO>();
            USUARIO = new HashSet<USUARIO>();
            VENDA = new HashSet<VENDA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PES_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PES_Dta_Cadastro { get; set; }

        [StringLength(100)]
        public string PES_Endereco { get; set; }

        [StringLength(50)]
        public string PES_Complemento { get; set; }

        [StringLength(100)]
        public string PES_Referencia { get; set; }

        [StringLength(80)]
        public string PES_Bairro { get; set; }

        [StringLength(40)]
        public string PES_Cidade { get; set; }

        [StringLength(9)]
        public string PES_Cep { get; set; }

        [StringLength(3)]
        public string PES_Uf { get; set; }

        [StringLength(150)]
        public string PES_Email { get; set; }

        [StringLength(100)]
        public string PES_Telefone { get; set; }

        [StringLength(100)]
        public string PES_Celular { get; set; }

        [StringLength(400)]
        public string PES_Observacao { get; set; }

        [Required]
        [StringLength(1)]
        public string PES_TipoPessoa { get; set; }

        [Required]
        [StringLength(3)]
        public string PES_TipoCadastro { get; set; }

        [StringLength(40)]
        public string PES_Bloqueado { get; set; }

        public decimal? PES_LimiteCredito { get; set; }

        public decimal? PES_Pct_Desconto { get; set; }

        public decimal? PES_Pct_Juros { get; set; }

        [StringLength(1)]
        public string PES_TipoCobranca { get; set; }

        public bool? PES_CobrancaJuros { get; set; }

        [StringLength(3)]
        public string PES_DiaCobranca { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PES_Dta_UltimaCompra { get; set; }

        public short? PDE_Codigo { get; set; }

        public short? CVN_Codigo { get; set; }

        public int? PER_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PES_DataExclusao { get; set; }

        [StringLength(8)]
        public string PES_NumeroEndereco { get; set; }

        public bool? PES_UtilizaNumeroOrdem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHEQUE> CHEQUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONSIGNADO> CONSIGNADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTAS_RECEBER> CONTAS_RECEBER { get; set; }

        public virtual CONVENIO CONVENIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COPS_MOVIMENTO> COPS_MOVIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEVOLUCAO> DEVOLUCAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENDERECO_ENTREGA> ENDERECO_ENTREGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTREGA_EFETUADA> ENTREGA_EFETUADA { get; set; }

        public virtual FISICA FISICA { get; set; }

        public virtual JURIDICA JURIDICA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_INFNOTAFISCAL> NFe_INFNOTAFISCAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORCAMENTO> ORCAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PESSOA_CLASSIFICACAO> PESSOA_CLASSIFICACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_COMPRA> SER_COMPRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_EQUIPAMENTO> SER_EQUIPAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_SERVICO> SER_SERVICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO> USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA> VENDA { get; set; }
    }
}
