namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GRUPO")]
    public partial class GRUPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GRUPO()
        {
            SUBSTANCIA = new HashSet<SUBSTANCIA>();
        }

        [Key]
        [StringLength(2)]
        public string GRP_Codigo { get; set; }

        [StringLength(30)]
        public string GRP_Descricao { get; set; }

        public short? TIO_Codigo { get; set; }

        public virtual TIPO_RECEITUARIO TIPO_RECEITUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUBSTANCIA> SUBSTANCIA { get; set; }
    }
}
