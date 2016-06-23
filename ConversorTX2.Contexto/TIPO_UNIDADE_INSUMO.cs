namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_UNIDADE_INSUMO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_UNIDADE_INSUMO()
        {
            ENTRADA_INSUMOS = new HashSet<ENTRADA_INSUMOS>();
            PERDA_INSUMOS = new HashSet<PERDA_INSUMOS>();
            SAIDA_INSUMOS = new HashSet<SAIDA_INSUMOS>();
            TRANSFERENCIA_INSUMOS = new HashSet<TRANSFERENCIA_INSUMOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TUI_Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string TUI_Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTRADA_INSUMOS> ENTRADA_INSUMOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERDA_INSUMOS> PERDA_INSUMOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAIDA_INSUMOS> SAIDA_INSUMOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFERENCIA_INSUMOS> TRANSFERENCIA_INSUMOS { get; set; }
    }
}
