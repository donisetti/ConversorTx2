namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMPRESSORA_MATRICIAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IMP_Codigo { get; set; }

        [Required]
        [StringLength(30)]
        public string IMP_Descricao { get; set; }
    }
}
