namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class REGISTRO_ECF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short REG_Codigo { get; set; }

        [Required]
        [StringLength(20)]
        public string REG_Serial { get; set; }

        public short IMP_Codigo { get; set; }

        [StringLength(1)]
        public string IMP_MFAdicional { get; set; }

        [StringLength(7)]
        public string IMP_TipoECF { get; set; }

        [StringLength(20)]
        public string IMP_ModeloECF { get; set; }

        [StringLength(10)]
        public string IMP_VersaoSB { get; set; }

        public DateTime? IMP_DataInstallSB { get; set; }

        public DateTime? IMP_HoraInstallSB { get; set; }

        public int? IMP_NumeroECF { get; set; }

        public virtual IMPRESSORA IMPRESSORA { get; set; }
    }
}
