namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDA_CPF_CNPJ
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long VDA_Codigo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string VDA_CpfCnpj { get; set; }
    }
}
