namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPRESAS_GRUPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPRESAS_GRUPO()
        {
            DEVOLUCAO = new HashSet<DEVOLUCAO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short EMP_Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string EMP_Descricao { get; set; }

        [Required]
        [StringLength(15)]
        public string EMP_Cnpj { get; set; }

        [StringLength(100)]
        public string EMP_Endereco { get; set; }

        [StringLength(50)]
        public string EMP_Cidade { get; set; }

        [StringLength(50)]
        public string EMP_Bairro { get; set; }

        [StringLength(3)]
        public string EMP_UF { get; set; }

        [StringLength(9)]
        public string EMP_CEP { get; set; }

        [StringLength(50)]
        public string EMP_Razao { get; set; }

        [StringLength(15)]
        public string EMP_Fone { get; set; }

        [StringLength(15)]
        public string EMP_Fax { get; set; }

        public decimal? EMP_SaldoContaCaixa { get; set; }

        [StringLength(5)]
        public string EMP_Numero { get; set; }

        [StringLength(22)]
        public string EMP_Complemento { get; set; }

        [StringLength(18)]
        public string EMP_Contato { get; set; }

        [StringLength(20)]
        public string EMP_InscricaoEstadual { get; set; }

        public short? EMP_RegimeTributario { get; set; }

        [StringLength(500)]
        public string EMP_DadosAdicionais { get; set; }

        [StringLength(50)]
        public string EMP_SenhaProxy { get; set; }

        [StringLength(50)]
        public string EMP_UsuarioProxy { get; set; }

        [StringLength(4)]
        public string EMP_VersaoSchema { get; set; }

        [StringLength(3)]
        public string EMP_ModeloNF { get; set; }

        public short? EMP_TipoAmbiente { get; set; }

        [StringLength(300)]
        public string EMP_CertificadoDigital { get; set; }

        [StringLength(50)]
        public string EMP_UsuarioSmtp { get; set; }

        [StringLength(150)]
        public string EMP_LicencaDLL { get; set; }

        [StringLength(2)]
        public string EMP_WebService_UF_Emitente { get; set; }

        public short? EMP_TipoServico { get; set; }

        [StringLength(150)]
        public string EMP_LocalLogoMarca { get; set; }

        [StringLength(100)]
        public string EMP_NomeServidorSmtp { get; set; }

        public bool? EMP_UtilizarSSL { get; set; }

        [StringLength(50)]
        public string EMP_SenhaSmtp { get; set; }

        [StringLength(100)]
        public string EMP_EmailSmtp { get; set; }

        [StringLength(150)]
        public string EMP_MensagemPadraoSmtp { get; set; }

        public bool? EMP_EnviarDanfe { get; set; }

        public short? EMP_CodigoCertificadora { get; set; }

        public short? EMP_NumeroPortaSmtp { get; set; }

        [StringLength(3)]
        public string EMP_TipoCertificado { get; set; }

        [StringLength(100)]
        public string EMP_Proxy { get; set; }

        [StringLength(30)]
        public string EMP_IM { get; set; }

        [StringLength(10)]
        public string EMP_CNAE { get; set; }

        [StringLength(50)]
        public string EMP_UltimaNota { get; set; }

        public short? EMP_SerieNF { get; set; }

        public decimal? EMP_AliqICMSSN { get; set; }

        [StringLength(100)]
        public string EMP_EmailContador { get; set; }

        public decimal? EMP_Aliquota_PIS { get; set; }

        public decimal? EMP_Aliquota_COFINS { get; set; }

        public short? EMP_Atividade { get; set; }

        [StringLength(1)]
        public string EMP_Perfil { get; set; }

        [StringLength(100)]
        public string EMP_NomeContador { get; set; }

        [StringLength(11)]
        public string EMP_CPFContador { get; set; }

        [StringLength(20)]
        public string EMP_CrcContador { get; set; }

        [StringLength(3)]
        public string EMP_ModeloNFCe { get; set; }

        public short? EMP_SerieNFCe { get; set; }

        [StringLength(50)]
        public string EMP_UltimaNotaNFCe { get; set; }

        [StringLength(2)]
        public string EMP_WebService_UF_EmitenteNFCe { get; set; }

        [StringLength(4)]
        public string EMP_VersaoSchemaNFCe { get; set; }

        public short? EMP_TipoAmbienteNFCe { get; set; }

        public short? EMP_TipoEmissaoNFCe { get; set; }

        public short? EMP_TipoEmissao { get; set; }

        [StringLength(6)]
        public string EMP_IdToken { get; set; }

        [StringLength(50)]
        public string EMP_CSC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEVOLUCAO> DEVOLUCAO { get; set; }
    }
}
