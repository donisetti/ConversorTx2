namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_PARTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SER_PARTE()
        {
            SER_SERVICO_PARTE = new HashSet<SER_SERVICO_PARTE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PAR_Codigo { get; set; }

        [StringLength(30)]
        public string PAR_Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_SERVICO_PARTE> SER_SERVICO_PARTE { get; set; }
    }
}
