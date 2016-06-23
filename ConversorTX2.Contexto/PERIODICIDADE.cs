namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PERIODICIDADE")]
    public partial class PERIODICIDADE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PDE_Codigo { get; set; }

        [StringLength(30)]
        public string PDE_Descricao { get; set; }
    }
}
