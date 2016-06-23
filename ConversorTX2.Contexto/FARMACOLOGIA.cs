namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FARMACOLOGIA")]
    public partial class FARMACOLOGIA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FIA_Codigo { get; set; }

        [Required]
        [StringLength(120)]
        public string FIA_Descricao { get; set; }
    }
}
