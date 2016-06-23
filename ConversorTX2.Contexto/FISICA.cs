namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FISICA")]
    public partial class FISICA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FISICA()
        {
            SAIDA_INSUMOS = new HashSet<SAIDA_INSUMOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PES_Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string FIS_Nome { get; set; }

        [StringLength(20)]
        public string FIS_Rg { get; set; }

        [StringLength(15)]
        public string FIS_Cpf { get; set; }

        [StringLength(100)]
        public string FIS_NomeMae { get; set; }

        [StringLength(1)]
        public string FIS_Sexo { get; set; }

        [StringLength(8)]
        public string FIS_OrgaoEmissor { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FIS_Dta_Nascimento { get; set; }

        [StringLength(100)]
        public string FIS_EnderecoComercial { get; set; }

        [StringLength(50)]
        public string FIS_LocalTrabalho { get; set; }

        [StringLength(50)]
        public string FIS_FoneComercial { get; set; }

        [StringLength(50)]
        public string FIS_FoneReferenciaComercial { get; set; }

        [StringLength(100)]
        public string FIS_NomePai { get; set; }

        [StringLength(100)]
        public string FIS_ReferenciaCom { get; set; }

        [StringLength(40)]
        public string FIS_CidadeLocalTrabalho { get; set; }

        public decimal? FIS_SalarioLocalTrabalho { get; set; }

        [StringLength(30)]
        public string FIS_TempoServico { get; set; }

        [StringLength(20)]
        public string Fis_EstadoCivil { get; set; }

        [StringLength(20)]
        public string FIS_Residencia { get; set; }

        [StringLength(100)]
        public string FIS_NomeConjuge { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FIS_DataNascimentoConjuge { get; set; }

        [StringLength(50)]
        public string FIS_LocalTrabalhoConjuge { get; set; }

        [StringLength(100)]
        public string FIS_EnderecoLocalTrabalhoConjuge { get; set; }

        [StringLength(40)]
        public string FIS_CidadeLocalTrabalhoConjuge { get; set; }

        [StringLength(50)]
        public string FIS_FoneLocalTrabalhoConjuge { get; set; }

        public decimal? FIS_SalarioConjuge { get; set; }

        [StringLength(30)]
        public string FIS_TempoServicoConjuge { get; set; }

        [StringLength(50)]
        public string FIS_FuncaoTrabalho { get; set; }

        [StringLength(30)]
        public string FIS_Natural { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAIDA_INSUMOS> SAIDA_INSUMOS { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
