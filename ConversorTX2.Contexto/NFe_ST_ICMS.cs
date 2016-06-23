namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFe_ST_ICMS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short STICMS_CodigoSituacaoTributaria { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string STICMS_Codigo { get; set; }

        [Required]
        [StringLength(150)]
        public string STICMS_Descricao { get; set; }
    }
}
