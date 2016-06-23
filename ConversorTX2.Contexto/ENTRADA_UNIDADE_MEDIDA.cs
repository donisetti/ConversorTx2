namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENTRADA_UNIDADE_MEDIDA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short EUN_Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string EUN_Descricao { get; set; }

        public short? UNI_Codigo { get; set; }

        public decimal? EUN_FatorSaida { get; set; }

        public decimal? EUN_FatorEntrada { get; set; }

        public virtual UNIDADE_MEDIDA UNIDADE_MEDIDA { get; set; }
    }
}
