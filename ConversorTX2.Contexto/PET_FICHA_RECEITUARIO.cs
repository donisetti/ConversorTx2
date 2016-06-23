namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PET_FICHA_RECEITUARIO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int REC_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REC_Data { get; set; }

        [StringLength(250)]
        public string REC_Anamnese { get; set; }

        [StringLength(250)]
        public string REC_Receita { get; set; }

        [StringLength(15)]
        public string REC_Peso { get; set; }

        [StringLength(50)]
        public string REC_Diagnostico { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? REC_DataRetorno { get; set; }

        public int CON_Codigo { get; set; }
    }
}
