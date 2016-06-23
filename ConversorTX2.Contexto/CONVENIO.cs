namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONVENIO")]
    public partial class CONVENIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONVENIO()
        {
            PESSOA = new HashSet<PESSOA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CVN_Codigo { get; set; }

        [Required]
        [StringLength(40)]
        public string CVN_Descricao { get; set; }

        public decimal? CVN_PctDesconto { get; set; }

        [StringLength(1)]
        public string CVN_CobrarJuros { get; set; }

        public decimal? CVN_LimiteCredito { get; set; }

        [StringLength(50)]
        public string CVN_Endereco { get; set; }

        [StringLength(30)]
        public string CVN_Complemento { get; set; }

        [StringLength(50)]
        public string CVN_Numero { get; set; }

        [StringLength(50)]
        public string CVN_Bairro { get; set; }

        [StringLength(50)]
        public string CVN_Fone { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CVN_DataCadastro { get; set; }

        public bool? CVN_Bloqueado { get; set; }

        [StringLength(50)]
        public string CVN_Municipio { get; set; }

        [StringLength(3)]
        public string CVN_UF { get; set; }

        [StringLength(9)]
        public string CVN_CEP { get; set; }

        [StringLength(50)]
        public string CVN_Contato { get; set; }

        [StringLength(150)]
        public string CVN_Observacao { get; set; }

        [StringLength(50)]
        public string CVN_Email { get; set; }

        [StringLength(15)]
        public string CVN_CNPJ { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CVN_DataExclusao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PESSOA> PESSOA { get; set; }
    }
}
