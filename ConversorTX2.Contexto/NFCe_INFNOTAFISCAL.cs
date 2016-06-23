namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCe_INFNOTAFISCAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCe_INFNOTAFISCAL()
        {
            NFCe_CONTINGENCIA = new HashSet<NFCe_CONTINGENCIA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NFCE_Codigo { get; set; }

        public long? VDA_Codigo { get; set; }

        public int? NFCE_Serie { get; set; }

        public int? NFCE_nNF { get; set; }

        public DateTime NFCE_DataHoraEmissao { get; set; }

        public DateTime? NFCE_DataHoraAutorizacao { get; set; }

        [StringLength(50)]
        public string NFe_ChaveAcesso { get; set; }

        [Column(TypeName = "text")]
        public string NFCE_xmlEnvio { get; set; }

        [Column(TypeName = "text")]
        public string NFCE_xmlRecebido { get; set; }

        public DateTime? NFCE_DataHoraCancelamento { get; set; }

        public short? NFCE_UsuarioCancelamento { get; set; }

        public short? NFCE_Status { get; set; }

        [Column(TypeName = "text")]
        public string NFCE_Mensagem { get; set; }

        [StringLength(20)]
        public string NFCe_Protocolo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCe_CONTINGENCIA> NFCe_CONTINGENCIA { get; set; }
    }
}
