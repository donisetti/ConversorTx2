namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFe_NOTA_CUPOM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NFC_Codigo { get; set; }

        public int? NFE_Codigo { get; set; }

        public long? VDA_Codigo { get; set; }

        public virtual NFe_INFNOTAFISCAL NFe_INFNOTAFISCAL { get; set; }

        public virtual VENDA VENDA { get; set; }
    }
}
