namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FABRICANTE_DISTRIBUIDORA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Codigo { get; set; }

        public short FAB_Codigo { get; set; }

        public short DIS_Codigo { get; set; }

        public decimal PCT_Desconto { get; set; }

        public virtual DISTRIBUIDORA DISTRIBUIDORA { get; set; }

        public virtual FABRICANTE FABRICANTE { get; set; }
    }
}
