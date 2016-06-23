namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PET_CONSULTA_SERVICO_nao_usar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CSE_Codigo { get; set; }

        public int? CON_Codigo { get; set; }

        public short? SER_Codigo { get; set; }

        public decimal? SER_Valor { get; set; }

        public decimal? SER_Quantidade { get; set; }
    }
}
