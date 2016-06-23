namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORDEM_SERVICO_PRODUTOS_ORDEM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IVD_Codigo { get; set; }

        [StringLength(15)]
        public string IPOS_Ordem { get; set; }

        public int? IPOS_ItemOrdem { get; set; }
    }
}
