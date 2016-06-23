namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MEDICOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEDICOS()
        {
            COPS_MOVIMENTO = new HashSet<COPS_MOVIMENTO>();
            SAIDA_INSUMOS = new HashSet<SAIDA_INSUMOS>();
            SAIDA_PRODUTOS = new HashSet<SAIDA_PRODUTOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MED_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime MED_DataCadastro { get; set; }

        [Required]
        [StringLength(50)]
        public string MED_Nome { get; set; }

        [Required]
        [StringLength(10)]
        public string MED_Numero_Registro { get; set; }

        [Required]
        [StringLength(20)]
        public string CAL_Sigla { get; set; }

        [Required]
        [StringLength(2)]
        public string EST_Sigla { get; set; }

        public virtual CONSELHO_PROFISSIONAL CONSELHO_PROFISSIONAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COPS_MOVIMENTO> COPS_MOVIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAIDA_INSUMOS> SAIDA_INSUMOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAIDA_PRODUTOS> SAIDA_PRODUTOS { get; set; }
    }
}
