namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_VENDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_VENDA()
        {
            ITENS_VENDA = new HashSet<ITENS_VENDA>();
            VENDA = new HashSet<VENDA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TPV_Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string TPV_Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITENS_VENDA> ITENS_VENDA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA> VENDA { get; set; }
    }
}
