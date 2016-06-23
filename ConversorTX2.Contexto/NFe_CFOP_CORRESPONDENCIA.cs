namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFe_CFOP_CORRESPONDENCIA
    {
        [Key]
        [StringLength(4)]
        public string CFOP_NF_Fornecedor { get; set; }

        [Required]
        [StringLength(4)]
        public string CFOP_Entrada { get; set; }

        [Required]
        [StringLength(4)]
        public string CFOP_Saida { get; set; }

        public virtual NFe_CFOP NFe_CFOP { get; set; }
    }
}
