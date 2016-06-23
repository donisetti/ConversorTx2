namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFe_FATURA
    {
        [Key]
        [StringLength(9)]
        public string NFe_Numero { get; set; }

        [Required]
        [StringLength(60)]
        public string FAT_Numero { get; set; }

        public decimal FAT_ValorOrigem { get; set; }

        public decimal FAT_ValorDesconto { get; set; }

        public decimal FAT_ValorLiquido { get; set; }
    }
}
