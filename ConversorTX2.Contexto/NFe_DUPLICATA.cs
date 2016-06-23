namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFe_DUPLICATA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(9)]
        public string NFe_Numero { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string DUP_Numero { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DUP_DataVencimento { get; set; }

        public decimal DUP_ValorDuplicata { get; set; }
    }
}
