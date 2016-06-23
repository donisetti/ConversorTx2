namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFe_IBPTAX_Tabela
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IBPT_CodigoNCM { get; set; }

        [StringLength(4)]
        public string IBPT_CodigoExcecaoNCM { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IBPT_Tabela { get; set; }

        [StringLength(400)]
        public string IBPT_Descricao { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal IBPT_AliquotaNacional { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal IBPT_AliquotaImportacao { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string IBPT_VersaoArquivoIBPTAX { get; set; }

        [Key]
        [Column(Order = 5)]
        public int IBPT_Codigo { get; set; }

        [StringLength(7)]
        public string IBPT_CEST { get; set; }
    }
}
