namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PET_CONSULTA_ITEM_nao_usar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CIT_Codigo { get; set; }

        public int? CON_Codigo { get; set; }

        public int? PRO_Codigo { get; set; }

        public decimal? PRO_Quantidade { get; set; }

        public decimal? PRO_Venda { get; set; }
    }
}
