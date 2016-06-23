namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PET_SERVICO_NAO USARMAIS")]
    public partial class PET_SERVICO_NAO_USARMAIS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SER_Codigo { get; set; }

        [StringLength(50)]
        public string SER_Descricao { get; set; }

        public decimal? SER_Valor { get; set; }

        [StringLength(100)]
        public string SER_Observacao { get; set; }
    }
}
