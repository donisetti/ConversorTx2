namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFe_CFOP
    {
        [Key]
        [StringLength(4)]
        public string CFOP_Codigo { get; set; }

        [Required]
        [StringLength(255)]
        public string CFOP_Descricao { get; set; }

        public virtual NFe_CFOP_CORRESPONDENCIA NFe_CFOP_CORRESPONDENCIA { get; set; }
    }
}
