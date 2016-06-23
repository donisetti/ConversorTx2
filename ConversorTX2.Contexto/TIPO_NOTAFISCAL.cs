namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_NOTAFISCAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_NOTAFISCAL()
        {
            ENTRADA_INSUMOS = new HashSet<ENTRADA_INSUMOS>();
            ENTRADA_PRODUTOS = new HashSet<ENTRADA_PRODUTOS>();
            TRANSFERENCIA_INSUMOS = new HashSet<TRANSFERENCIA_INSUMOS>();
            TRANSFERENCIA_PRODUTOS = new HashSet<TRANSFERENCIA_PRODUTOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TNF_Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string TNF_Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTRADA_INSUMOS> ENTRADA_INSUMOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTRADA_PRODUTOS> ENTRADA_PRODUTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFERENCIA_INSUMOS> TRANSFERENCIA_INSUMOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFERENCIA_PRODUTOS> TRANSFERENCIA_PRODUTOS { get; set; }
    }
}
