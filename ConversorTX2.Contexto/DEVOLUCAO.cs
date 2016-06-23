namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEVOLUCAO")]
    public partial class DEVOLUCAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEVOLUCAO()
        {
            DEVOLUCAO_ITEM = new HashSet<DEVOLUCAO_ITEM>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DEV_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DEV_DataMovimento { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DEV_DataFechamento { get; set; }

        public decimal? DEV_ValorDevolucao { get; set; }

        public short? USU_Codigo_movimento { get; set; }

        public short? USU_Codigo_Fechamento { get; set; }

        public int? PES_Codigo { get; set; }

        public short? EMP_Codigo { get; set; }

        public long? VDA_Codigo { get; set; }

        public virtual EMPRESAS_GRUPO EMPRESAS_GRUPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEVOLUCAO_ITEM> DEVOLUCAO_ITEM { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        public virtual VENDA VENDA { get; set; }
    }
}
