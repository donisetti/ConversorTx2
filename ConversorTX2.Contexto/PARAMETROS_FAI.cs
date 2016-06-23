namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PARAMETROS_FAI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PARF_Codigo { get; set; }

        public short? EMP_Codigo { get; set; }

        public bool? PARF_AtualizaClassificacao { get; set; }
    }
}
