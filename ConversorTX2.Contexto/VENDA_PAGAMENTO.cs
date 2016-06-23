namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDA_PAGAMENTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long VPG_Codigo { get; set; }

        public decimal VPG_Valor { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VPG_DataVencimento { get; set; }

        public short? FPG_Codigo { get; set; }

        public long? VDA_Codigo { get; set; }

        public virtual VENDA VENDA { get; set; }
    }
}
