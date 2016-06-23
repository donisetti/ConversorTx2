namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHEQUE_TELEFONE_SACADO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TES_Codigo { get; set; }

        [StringLength(2)]
        public string TES_Area { get; set; }

        [StringLength(50)]
        public string TES_Telefone { get; set; }

        public int? SAC_Codigo { get; set; }

        public virtual CHEQUE_SACADO CHEQUE_SACADO { get; set; }
    }
}
