namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMPRESSAO_ETIQUETAS_TEMP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ETT_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ETT_DataEntrada { get; set; }

        public decimal? ETT_Quantidade { get; set; }

        public long? PRO_Codigo { get; set; }

        public short? EMP_Codigo { get; set; }
    }
}
