namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ENTRADA")]
    public partial class ENTRADA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ENT_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ENT_DataEntrada { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ENT_DataEncerramento { get; set; }

        [StringLength(15)]
        public string ENT_NotaFiscal { get; set; }

        public decimal? ENT_ValorNota { get; set; }

        public int? FOR_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ENT_DataNotaFiscal { get; set; }

        public short? USU_Codigo { get; set; }

        public short? EMP_Codigo { get; set; }

        public decimal? ENT_ValorIpiEntrada { get; set; }

        public decimal? ENT_ValorFrete { get; set; }

        public decimal? ENT_ValorSubEntrada { get; set; }

        public decimal? ENT_ValorProdutos { get; set; }

        [StringLength(50)]
        public string ENT_ChNFe { get; set; }

        public decimal? ENT_ValorSeguro { get; set; }

        public decimal? ENT_ValorDesconto { get; set; }

        [StringLength(3)]
        public string ENT_Serie { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ENT_DataImportacao { get; set; }

        public bool? ENT_AproveitarICMS { get; set; }

        [Column(TypeName = "text")]
        public string ENT_Xml { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
