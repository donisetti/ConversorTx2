namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DISTRIBUIDORA")]
    public partial class DISTRIBUIDORA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DISTRIBUIDORA()
        {
            FABRICANTE_DISTRIBUIDORA = new HashSet<FABRICANTE_DISTRIBUIDORA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DIS_Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string DIS_Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FABRICANTE_DISTRIBUIDORA> FABRICANTE_DISTRIBUIDORA { get; set; }
    }
}
