namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PET_RACA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short RAC_Codigo { get; set; }

        [StringLength(50)]
        public string RAC_Descricao { get; set; }

        public short ESP_Codigo { get; set; }

        public virtual PET_ESPECIE PET_ESPECIE { get; set; }
    }
}
