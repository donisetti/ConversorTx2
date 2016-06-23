namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFe_INFNOTAFISCAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFe_INFNOTAFISCAL()
        {
            NFe_NOTA_CUPOM = new HashSet<NFe_NOTA_CUPOM>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NFE_Codigo { get; set; }

        [StringLength(50)]
        public string NFe_NProtocolo { get; set; }

        public int? NFE_Cupom { get; set; }

        public int? NFe_nNF { get; set; }

        public DateTime NFe_DataHoraProtocolo { get; set; }

        [Required]
        [StringLength(50)]
        public string NFe_Enviada { get; set; }

        [Column(TypeName = "text")]
        public string NFE_xmlEnvio { get; set; }

        [Column(TypeName = "text")]
        public string NFE_xmlRecebido { get; set; }

        public DateTime? NFE_DataHoraCancelamento { get; set; }

        public short? NFE_UsuarioCancelamento { get; set; }

        [StringLength(1)]
        public string NFE_SituacaoEnvio { get; set; }

        public long? VDA_Codigo { get; set; }

        public int? PES_Codigo { get; set; }

        public decimal? NFe_Valor { get; set; }

        [StringLength(50)]
        public string NFe_ChaveAcesso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_NOTA_CUPOM> NFe_NOTA_CUPOM { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
