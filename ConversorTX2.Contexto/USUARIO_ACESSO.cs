namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USUARIO_ACESSO
    {
        public int? USR_Codigo { get; set; }

        [StringLength(50)]
        public string USA_Grau_1 { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string USA_Grau_2 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string USA_Grau_3 { get; set; }
    }
}
