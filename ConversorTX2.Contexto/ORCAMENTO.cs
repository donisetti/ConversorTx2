namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORCAMENTO")]
    public partial class ORCAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORCAMENTO()
        {
            VENDA = new HashSet<VENDA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ORC_Codigo { get; set; }

        public DateTime ORC_DataLancamento { get; set; }

        public decimal ORC_Valor { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ORC_DataEstorno { get; set; }

        public short? ORC_UsuarioEstorno { get; set; }

        public short Vda_Vendedor { get; set; }

        public int PES_Codigo { get; set; }

        public long? VDA_Codigo { get; set; }

        [StringLength(200)]
        public string ORC_Observacoes { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA> VENDA { get; set; }
    }
}
