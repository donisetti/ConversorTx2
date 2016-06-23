namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCe_CONTINGENCIA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CON_Codigo { get; set; }

        public long? NFCE_Codigo { get; set; }

        [Column(TypeName = "text")]
        public string CON_Xml { get; set; }

        public virtual NFCe_INFNOTAFISCAL NFCe_INFNOTAFISCAL { get; set; }
    }
}
