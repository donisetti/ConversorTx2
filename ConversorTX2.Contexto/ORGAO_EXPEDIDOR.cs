namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORGAO_EXPEDIDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORGAO_EXPEDIDOR()
        {
            DOCUMENTO_CLIENTES = new HashSet<DOCUMENTO_CLIENTES>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short OEX_Codigo { get; set; }

        [Required]
        [StringLength(10)]
        public string OEX_Sigla { get; set; }

        [Required]
        [StringLength(50)]
        public string OEX_Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENTO_CLIENTES> DOCUMENTO_CLIENTES { get; set; }
    }
}
