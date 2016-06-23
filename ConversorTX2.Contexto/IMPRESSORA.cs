namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IMPRESSORA")]
    public partial class IMPRESSORA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMPRESSORA()
        {
            FORMA_PAGAMENTO_IMPRESSORA = new HashSet<FORMA_PAGAMENTO_IMPRESSORA>();
            REGISTRO_ECF = new HashSet<REGISTRO_ECF>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IMP_Codigo { get; set; }

        [Required]
        [StringLength(30)]
        public string IMP_Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORMA_PAGAMENTO_IMPRESSORA> FORMA_PAGAMENTO_IMPRESSORA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTRO_ECF> REGISTRO_ECF { get; set; }
    }
}
