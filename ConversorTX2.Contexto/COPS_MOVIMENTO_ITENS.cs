namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COPS_MOVIMENTO_ITENS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long IMO_Codigo { get; set; }

        public long MOV_Codigo { get; set; }

        public decimal? IMO_Quantidade { get; set; }

        public int PRO_Codigo { get; set; }

        public virtual COPS_MOVIMENTO COPS_MOVIMENTO { get; set; }
    }
}
