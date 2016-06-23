namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FORMA_PAGAMENTO_IMPRESSORA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FPI_Codigo { get; set; }

        public short? BAK_Codigo { get; set; }

        public short? FPG_Codigo { get; set; }

        public short? IMP_Codigo { get; set; }

        public short? FPG_Codigo_ImpFiscal { get; set; }

        public virtual BACKUPS BACKUPS { get; set; }

        public virtual FORMA_PAGAMENTO FORMA_PAGAMENTO { get; set; }

        public virtual IMPRESSORA IMPRESSORA { get; set; }
    }
}
