namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_SERVICO_PARTE_TECNICO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SERPARTEC_Codigo { get; set; }

        public short? USR_Codigo { get; set; }

        public int? SERPAR_Codigo { get; set; }

        public virtual SER_SERVICO_PARTE SER_SERVICO_PARTE { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
