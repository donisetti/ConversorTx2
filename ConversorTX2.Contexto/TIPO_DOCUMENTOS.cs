namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_DOCUMENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_DOCUMENTOS()
        {
            DOCUMENTO_CLIENTES = new HashSet<DOCUMENTO_CLIENTES>();
            SAIDA_INSUMOS = new HashSet<SAIDA_INSUMOS>();
            SAIDA_PRODUTOS = new HashSet<SAIDA_PRODUTOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TDO_Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string TDO_Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENTO_CLIENTES> DOCUMENTO_CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAIDA_INSUMOS> SAIDA_INSUMOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAIDA_PRODUTOS> SAIDA_PRODUTOS { get; set; }
    }
}
