namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ESTADO")]
    public partial class ESTADO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short EST_Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string EST_Descricao { get; set; }

        [StringLength(2)]
        public string EST_Sigla { get; set; }
    }
}
