namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_EQUIPAMENTO_SERVICO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EQUISER_Codigo { get; set; }

        public int? EQUI_Codigo { get; set; }

        public int? SER_Codigo { get; set; }

        public virtual SER_EQUIPAMENTO SER_EQUIPAMENTO { get; set; }

        public virtual SER_SERVICO SER_SERVICO { get; set; }
    }
}
