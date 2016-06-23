namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JURIDICA")]
    public partial class JURIDICA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JURIDICA()
        {
            PERDA_INSUMOS = new HashSet<PERDA_INSUMOS>();
            SAIDA_INSUMOS = new HashSet<SAIDA_INSUMOS>();
            TRANSFERENCIA_INSUMOS = new HashSet<TRANSFERENCIA_INSUMOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PES_Codigo { get; set; }

        [Required]
        [StringLength(15)]
        public string JUR_Cnpj { get; set; }

        [Required]
        [StringLength(50)]
        public string JUR_RazaoSocial { get; set; }

        [StringLength(50)]
        public string JUR_NomeFantasia { get; set; }

        [StringLength(20)]
        public string JUR_InscricaoEstadual { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? JUR_Dta_Fundacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERDA_INSUMOS> PERDA_INSUMOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAIDA_INSUMOS> SAIDA_INSUMOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFERENCIA_INSUMOS> TRANSFERENCIA_INSUMOS { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
