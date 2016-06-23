namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PSICO_CONFIGURACOES
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PSI_Codigo { get; set; }

        [StringLength(50)]
        public string PSI_HashIdentificacao { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PSI_DataInicioPeriodo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PSI_DataFimPeriodo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PSI_DataEnvioAnvisa { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime PSI_DataGeracaoArquivo { get; set; }

        [Required]
        [StringLength(150)]
        public string PSI_CaminhoArquivo { get; set; }

        [Required]
        [StringLength(1)]
        public string PSI_ValidadoAnvisa { get; set; }

        [StringLength(150)]
        public string PSI_MsgRetorno { get; set; }
    }
}
