namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PESSOA_CLASSIFICACAO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PCLAS_Codigo { get; set; }

        public int? PES_Codigo { get; set; }

        public short? CLA_codigo { get; set; }

        public decimal? PCLAS_Desconto { get; set; }

        public virtual CLASSIFICACAO CLASSIFICACAO { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
