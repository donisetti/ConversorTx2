namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PSICO_CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PSICO_CLIENTE()
        {
            DOCUMENTO_CLIENTES = new HashSet<DOCUMENTO_CLIENTES>();
            SAIDA_PRODUTOS = new HashSet<SAIDA_PRODUTOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PCLI_Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string PCLI_Nome { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PCLI_DataCadastro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENTO_CLIENTES> DOCUMENTO_CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAIDA_PRODUTOS> SAIDA_PRODUTOS { get; set; }
    }
}
