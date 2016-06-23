namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_USO_MEDICAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_USO_MEDICAMENTO()
        {
            SAIDA_INSUMOS = new HashSet<SAIDA_INSUMOS>();
            SAIDA_PRODUTOS = new HashSet<SAIDA_PRODUTOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TUM_Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string TUM_Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAIDA_INSUMOS> SAIDA_INSUMOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAIDA_PRODUTOS> SAIDA_PRODUTOS { get; set; }
    }
}
