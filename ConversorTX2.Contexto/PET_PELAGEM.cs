namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PET_PELAGEM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PEL_Codigo { get; set; }

        [StringLength(30)]
        public string PEL_Descricao { get; set; }
    }
}
