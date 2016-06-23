namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTAS_RECEBER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTAS_RECEBER()
        {
            CONTAS_RECEBIMENTO = new HashSet<CONTAS_RECEBIMENTO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CRE_Codigo { get; set; }

        public decimal? CRE_ValorPagamento { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CRE_DataVencimento { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CRE_DataEmCobranca { get; set; }

        public decimal? CRE_ValorAbatido { get; set; }

        public decimal? CRE_ValorBruto { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CRE_DataAbatimento { get; set; }

        [StringLength(1)]
        public string CRE_Situacao { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CRE_DataRecebimento { get; set; }

        public decimal? CRE_ValorJurosAbatidos { get; set; }

        public decimal? CRE_ValorJurosRestantes { get; set; }

        public decimal? VDA_ValorCredito { get; set; }

        [StringLength(7)]
        public string CRE_ParcelaTexto { get; set; }

        public decimal? CRE_ValorDescontoRecebimento { get; set; }

        public decimal? CRE_PctDescontoRecebimento { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CRE_DataEstorno { get; set; }

        public short? CRE_UsuarioEstorno { get; set; }

        public int? USU_Codigo { get; set; }

        public int? USU_Codigo_Desconto { get; set; }

        public long VDA_Codigo { get; set; }

        public int? PES_CODIGO { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        public virtual VENDA VENDA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTAS_RECEBIMENTO> CONTAS_RECEBIMENTO { get; set; }
    }
}
