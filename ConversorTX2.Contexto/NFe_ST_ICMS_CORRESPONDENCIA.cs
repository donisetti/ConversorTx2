namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFe_ST_ICMS_CORRESPONDENCIA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string STICMS_NF_Fornecedor { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string STICMS_Saida { get; set; }

        public short STICMS_CodigoSituacaoTributaria { get; set; }

        public virtual NFe_ST_ICMS_CORRESPONDENCIA NFe_ST_ICMS_CORRESPONDENCIA1 { get; set; }

        public virtual NFe_ST_ICMS_CORRESPONDENCIA NFe_ST_ICMS_CORRESPONDENCIA2 { get; set; }
    }
}
