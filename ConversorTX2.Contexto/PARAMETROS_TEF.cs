namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PARAMETROS_TEF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TEF_NumeroEstacao { get; set; }

        public bool? TEF_PossuiTEF { get; set; }

        [StringLength(50)]
        public string TEF_ContraSenha { get; set; }

        public short? TEF_CodigoGP { get; set; }
    }
}
