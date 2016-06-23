namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONSIGNADO")]
    public partial class CONSIGNADO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CDO_Codigo { get; set; }

        public DateTime CDO_DataLancamento { get; set; }

        public decimal CDO_Valor { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CDO_DataEstorno { get; set; }

        public short? CDO_UsuarioEstorno { get; set; }

        public short Vda_Vendedor { get; set; }

        public int PES_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CDO_DataFechamento { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
