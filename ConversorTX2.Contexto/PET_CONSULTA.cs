namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PET_CONSULTA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CON_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CON_DataMovimento { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CON_DataFechamento { get; set; }

        [StringLength(150)]
        public string CON_Observacao { get; set; }

        public int MED_Codigo { get; set; }

        public int PAC_Codigo { get; set; }

        public virtual PET_PACIENTE PET_PACIENTE { get; set; }
    }
}
