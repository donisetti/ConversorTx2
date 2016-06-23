namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_COMPRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SER_COMPRA()
        {
            SER_COMPRA_ITEM = new HashSet<SER_COMPRA_ITEM>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COM_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? COM_DataLancamento { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? COM_DataFechamento { get; set; }

        public int? PES_Codigo { get; set; }

        public int? FOR_Codigo { get; set; }

        public short? USR_Codigo { get; set; }

        public virtual FORNECEDORES FORNECEDORES { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_COMPRA_ITEM> SER_COMPRA_ITEM { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
