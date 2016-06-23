namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_SERVICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SER_SERVICO()
        {
            SER_EQUIPAMENTO_SERVICO = new HashSet<SER_EQUIPAMENTO_SERVICO>();
            SER_SERVICO_PARTE = new HashSet<SER_SERVICO_PARTE>();
            VENDA = new HashSet<VENDA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SER_Codigo { get; set; }

        public DateTime? SER_DataMovimento { get; set; }

        public DateTime? SER_DataFechamento { get; set; }

        public int? VEI_Codigo { get; set; }

        public int PES_Codigo { get; set; }

        public short? USR_Codigo { get; set; }

        public int? EQUI_Codigo { get; set; }

        [StringLength(50)]
        public string SER_NumeroControle { get; set; }

        public short? STA_Codigo { get; set; }

        [StringLength(300)]
        public string SER_DefeitoReclamado { get; set; }

        [StringLength(50)]
        public string SER_Solicitante { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SER_DataFaturado { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SER_DataInativo { get; set; }

        [StringLength(15)]
        public string SER_OSCliente { get; set; }

        [StringLength(300)]
        public string SER_SolucaoDefeito { get; set; }

        [StringLength(15)]
        public string SER_KmHrs { get; set; }

        [StringLength(10)]
        public string SER_NotaFiscalFatura { get; set; }

        [StringLength(10)]
        public string SER_NotaFiscalServico { get; set; }

        [StringLength(10)]
        public string SER_NumeroPedidoCliente { get; set; }

        public short? TSE_Codigo { get; set; }

        [StringLength(300)]
        public string SER_Observacao { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SER_DataEntrega { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SER_DataDevolucao { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SER_DataEstorno { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        public virtual SER_EQUIPAMENTO SER_EQUIPAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_EQUIPAMENTO_SERVICO> SER_EQUIPAMENTO_SERVICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_SERVICO_PARTE> SER_SERVICO_PARTE { get; set; }

        public virtual SER_STATUS SER_STATUS { get; set; }

        public virtual SER_TIPO_SERVICO SER_TIPO_SERVICO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA> VENDA { get; set; }

        public virtual SER_VEICULO SER_VEICULO { get; set; }
    }
}
