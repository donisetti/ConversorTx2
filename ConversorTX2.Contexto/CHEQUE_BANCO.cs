namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHEQUE_BANCO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHEQUE_BANCO()
        {
            CHEQUE_SACADO = new HashSet<CHEQUE_SACADO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short BAN_Codigo { get; set; }

        [StringLength(5)]
        public string BAN_Numero { get; set; }

        [StringLength(50)]
        public string BAN_Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHEQUE_SACADO> CHEQUE_SACADO { get; set; }
    }
}
