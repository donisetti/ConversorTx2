namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHEQUE")]
    public partial class CHEQUE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CHE_Codigo { get; set; }

        [StringLength(15)]
        public string CHE_Numero { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CHE_DataMovimento { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CHE_DataBase { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CHE_DataVencimento { get; set; }

        public decimal? CHE_Valor { get; set; }

        [StringLength(50)]
        public string CHE_Observacao { get; set; }

        public int SAC_Codigo { get; set; }

        public int? PES_Codigo { get; set; }

        public long VDA_Codigo { get; set; }

        public short USR_Codigo { get; set; }

        public short? STS_Codigo { get; set; }

        public virtual CHEQUE_SACADO CHEQUE_SACADO { get; set; }

        public virtual CHEQUE_STATUS CHEQUE_STATUS { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual VENDA VENDA { get; set; }
    }
}
