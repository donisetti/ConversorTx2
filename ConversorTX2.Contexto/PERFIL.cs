namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PERFIL")]
    public partial class PERFIL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PER_Codigo { get; set; }

        [StringLength(40)]
        public string PER_Descricao { get; set; }

        [StringLength(1)]
        public string PER_Liberado { get; set; }
    }
}
