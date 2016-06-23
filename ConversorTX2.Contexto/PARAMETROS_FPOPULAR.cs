namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PARAMETROS_FPOPULAR
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FPO_USUARIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FPO_SENHA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string FPO_CODIGO_SOLICITACAO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string FPO_CODIGO_AUTORIZACAOFP { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string FPO_CODIGO_CUPOM { get; set; }

        [StringLength(30)]
        public string FPO_UsuarioVendedor { get; set; }

        [StringLength(30)]
        public string FPO_SenhaVendedor { get; set; }

        public short? FPO_Codigo { get; set; }
    }
}
