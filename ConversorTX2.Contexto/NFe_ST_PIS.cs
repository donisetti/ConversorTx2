namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFe_ST_PIS
    {
        [Key]
        [StringLength(3)]
        public string STPIS_Codigo { get; set; }

        [Required]
        [StringLength(150)]
        public string STPIS_Descricao { get; set; }
    }
}
