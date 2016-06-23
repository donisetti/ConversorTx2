namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PAF_RELACAO_REDUCAO_Z
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int REDZ_Codigo { get; set; }

        public short? IMP_Codigo { get; set; }

        [StringLength(4)]
        public string REDZ_NumeroUsuario { get; set; }

        [StringLength(6)]
        public string REDZ_CRZ { get; set; }

        [StringLength(6)]
        public string REDZ_COO { get; set; }

        [StringLength(6)]
        public string REDZ_CRO { get; set; }

        [StringLength(8)]
        public string REDZ_DataMovimento { get; set; }

        [StringLength(8)]
        public string REDZ_DataEmissao { get; set; }

        [StringLength(8)]
        public string REDZ_HoraEmissao { get; set; }

        [StringLength(18)]
        public string REDZ_VendaBruta { get; set; }

        [StringLength(1)]
        public string REDZ_ParametroECF { get; set; }

        [StringLength(18)]
        public string REDZ_ValorTotalizadorGeral { get; set; }
    }
}
