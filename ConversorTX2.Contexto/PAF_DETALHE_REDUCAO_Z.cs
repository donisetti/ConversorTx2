namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PAF_DETALHE_REDUCAO_Z
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DTREDZ_Codigo { get; set; }

        public short? IMP_Codigo { get; set; }

        [StringLength(4)]
        public string DTREDZ_NumeroUsuario { get; set; }

        [StringLength(6)]
        public string DTREDZ_CRZ { get; set; }

        [StringLength(14)]
        public string DTREDZ_TotalizadorParcial { get; set; }

        [StringLength(14)]
        public string DTREDZ_ValorAcumulado { get; set; }
    }
}
