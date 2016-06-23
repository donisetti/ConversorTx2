namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BACKUPS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BACKUPS()
        {
            FORMA_PAGAMENTO_IMPRESSORA = new HashSet<FORMA_PAGAMENTO_IMPRESSORA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short BAK_Codigo { get; set; }

        [StringLength(15)]
        public string BAK_IPServidor { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BAK_Data { get; set; }

        [StringLength(1)]
        public string BAK_Status { get; set; }

        public short? BAK_NumeroEstacao { get; set; }

        [StringLength(15)]
        public string BAK_NomeEstacao { get; set; }

        public short? EMP_Codigo { get; set; }

        public int? CXO_Codigo { get; set; }

        public short? CXA_Codigo { get; set; }

        [StringLength(60)]
        public string BAK_ImpressoraConfigurada { get; set; }

        [StringLength(60)]
        public string BAK_ModeloImpressoraCodigoBarras { get; set; }

        [StringLength(2)]
        public string BAK_QuantidadeLinhaCupom40 { get; set; }

        [StringLength(2)]
        public string BAK_QuantidadeLinhaCupom80 { get; set; }

        public bool? BAK_ImprimePromissoriaCupom40 { get; set; }

        public bool? BAK_ImprimePromissoriaCupom40SimNao { get; set; }

        public bool? BAK_ImprimeDescontoCupom { get; set; }

        public bool? BAK_ControlaCaixaOperador { get; set; }

        public bool? BAK_ImprimirCupom { get; set; }

        public bool? BAK_SolicitarImprimirSimNao { get; set; }

        public bool? BAK_ImprimirEm_Cupom40Colunas { get; set; }

        [StringLength(1)]
        public string BAK_ModeloCupom_MATRICIAL_HP { get; set; }

        [StringLength(1)]
        public string BAK_ModeloOrcamento_MATRICIAL_HP { get; set; }

        [StringLength(1)]
        public string BAK_ViasReimpressao { get; set; }

        [StringLength(10)]
        public string BAK_NomePortaSerial { get; set; }

        [StringLength(1)]
        public string BAK_Paridade { get; set; }

        public int? BAK_BaudRate { get; set; }

        public short? BAK_DataBits { get; set; }

        [StringLength(1)]
        public string BAK_StopBits { get; set; }

        [StringLength(60)]
        public string BAK_ImpressoraConfiguradaEtiqueta { get; set; }

        [StringLength(1)]
        public string BAK_ModeloEtiqueta { get; set; }

        public bool? BAK_UsarArredondamentoIF { get; set; }

        [StringLength(30)]
        public string BAK_NomeBalancaCheckout { get; set; }

        public int? BAK_UsaNF { get; set; }

        [StringLength(1)]
        public string BAK_ModeloCupomConsignado_MATRICIAL_HP { get; set; }

        [StringLength(8)]
        public string BAK_PortaSerialECF { get; set; }

        public int? BAK_Bloqueada { get; set; }

        public bool? BAK_EmiteNFCe { get; set; }

        public short? BAK_IMPFisicaCodigo { get; set; }

        [StringLength(6)]
        public string BAK_IMPFisicaPortaCom { get; set; }

        public short? BAK_SerieNFCe { get; set; }

        public long? BAK_UltimaNFCe { get; set; }

        public bool? BAK_EmiteNFe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMA_PAGAMENTO_IMPRESSORA> FORMA_PAGAMENTO_IMPRESSORA { get; set; }
    }
}
