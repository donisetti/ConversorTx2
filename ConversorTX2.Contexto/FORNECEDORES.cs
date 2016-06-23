namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORNECEDORES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FORNECEDORES()
        {
            SER_COMPRA = new HashSet<SER_COMPRA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FOR_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FOR_DataCadastro { get; set; }

        [StringLength(50)]
        public string FOR_Nome { get; set; }

        [StringLength(50)]
        public string FOR_Fantasia { get; set; }

        [StringLength(15)]
        public string FOR_Rg_InscricaoEstadual { get; set; }

        [StringLength(15)]
        public string FOR_Cpf_Cnpj { get; set; }

        [StringLength(100)]
        public string FOR_Endereco { get; set; }

        [StringLength(50)]
        public string FOR_Complemento { get; set; }

        [StringLength(50)]
        public string FOR_Bairro { get; set; }

        [StringLength(9)]
        public string FOR_Cep { get; set; }

        [StringLength(50)]
        public string FOR_Cidade { get; set; }

        [StringLength(3)]
        public string FOR_Uf { get; set; }

        [StringLength(100)]
        public string FOR_Telefone { get; set; }

        [StringLength(150)]
        public string FOR_Email { get; set; }

        [StringLength(100)]
        public string FOR_Observacao { get; set; }

        [StringLength(1)]
        public string FOR_TipoCadastro { get; set; }

        public int? PCT_CodigoReduzido { get; set; }

        [StringLength(50)]
        public string FOR_Atividade { get; set; }

        public virtual PLANO_CONTAS PLANO_CONTAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_COMPRA> SER_COMPRA { get; set; }
    }
}
