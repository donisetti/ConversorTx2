namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DOCUMENTO_CLIENTES
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DCLI_Codigo { get; set; }

        [Required]
        [StringLength(20)]
        public string DCLI_Numero_Documento { get; set; }

        [Required]
        [StringLength(3)]
        public string DCLI_UFEmissaoDocumento { get; set; }

        public int PCLI_Codigo { get; set; }

        public short TDO_Codigo { get; set; }

        public short OEX_Codigo { get; set; }

        public virtual ORGAO_EXPEDIDOR ORGAO_EXPEDIDOR { get; set; }

        public virtual PSICO_CLIENTE PSICO_CLIENTE { get; set; }

        public virtual TIPO_DOCUMENTOS TIPO_DOCUMENTOS { get; set; }
    }
}
