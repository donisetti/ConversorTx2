namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IMPRESSAO_ETIQUETAS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRO_Codigo { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ETQ_Quantidade { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime ETQ_DataImpressão { get; set; }

        [Key]
        [Column(Order = 3)]
        public int ETQ_Codigo { get; set; }

        public short? EMP_Codigo { get; set; }
    }
}
