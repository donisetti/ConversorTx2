namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFe_IBGE_CIDADE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CID_Codigo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CID_NomeCidade { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string CID_SiglaEstado { get; set; }
    }
}
