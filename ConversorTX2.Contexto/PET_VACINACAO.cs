namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PET_VACINACAO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short VCO_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VCO_DataAgendamentoVacina { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VCO_DataAplicacaoVacina { get; set; }

        public short? VAC_Codigo { get; set; }

        public int? PAC_Codigo { get; set; }

        public virtual PET_PACIENTE PET_PACIENTE { get; set; }

        public virtual PET_VACINA PET_VACINA { get; set; }
    }
}
