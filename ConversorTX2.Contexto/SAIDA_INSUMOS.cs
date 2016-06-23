namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAIDA_INSUMOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SIN_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SIN_DataVenda { get; set; }

        [Required]
        [StringLength(20)]
        public string SIN_NumeroReceita { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SIN_DataReceita { get; set; }

        [Required]
        [StringLength(30)]
        public string SIN_NumeroLote { get; set; }

        public decimal SIN_Qtde_UnidadeInsumo { get; set; }

        public decimal SIN_Qtde_UnidadeFarmacotecnica { get; set; }

        public short SUB_Codigo { get; set; }

        public short TUM_Codigo { get; set; }

        public short TDO_Codigo { get; set; }

        public int MED_Codigo { get; set; }

        public short TIO_Codigo { get; set; }

        public int CLI_Codigo { get; set; }

        public int FOR_Codigo { get; set; }

        public short TUI_Codigo { get; set; }

        public short TUF_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SIN_DataEnvio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime SIN_DataMovimentacao { get; set; }

        public virtual FISICA FISICA { get; set; }

        public virtual JURIDICA JURIDICA { get; set; }

        public virtual MEDICOS MEDICOS { get; set; }

        public virtual SAIDA_INSUMOS SAIDA_INSUMOS1 { get; set; }

        public virtual SAIDA_INSUMOS SAIDA_INSUMOS2 { get; set; }

        public virtual SUBSTANCIA SUBSTANCIA { get; set; }

        public virtual TIPO_DOCUMENTOS TIPO_DOCUMENTOS { get; set; }

        public virtual TIPO_RECEITUARIO TIPO_RECEITUARIO { get; set; }

        public virtual TIPO_UNIDADE_FARMACOTECNICA TIPO_UNIDADE_FARMACOTECNICA { get; set; }

        public virtual TIPO_UNIDADE_INSUMO TIPO_UNIDADE_INSUMO { get; set; }

        public virtual TIPO_USO_MEDICAMENTO TIPO_USO_MEDICAMENTO { get; set; }
    }
}
