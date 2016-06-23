namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUBSTANCIA")]
    public partial class SUBSTANCIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUBSTANCIA()
        {
            ENTRADA_INSUMOS = new HashSet<ENTRADA_INSUMOS>();
            PERDA_INSUMOS = new HashSet<PERDA_INSUMOS>();
            SAIDA_INSUMOS = new HashSet<SAIDA_INSUMOS>();
            TRANSFERENCIA_INSUMOS = new HashSet<TRANSFERENCIA_INSUMOS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SUB_Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string SUB_Descricao { get; set; }

        [StringLength(2)]
        public string GRP_Codigo { get; set; }

        [StringLength(10)]
        public string SUB_DCB { get; set; }

        [StringLength(20)]
        public string SUB_CAS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SUB_DataInclusao { get; set; }

        [StringLength(10)]
        public string NUM_Concent { get; set; }

        public short? TIO_Codigo { get; set; }

        public bool? SUB_Controlada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTRADA_INSUMOS> ENTRADA_INSUMOS { get; set; }

        public virtual GRUPO GRUPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERDA_INSUMOS> PERDA_INSUMOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAIDA_INSUMOS> SAIDA_INSUMOS { get; set; }

        public virtual TIPO_RECEITUARIO TIPO_RECEITUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFERENCIA_INSUMOS> TRANSFERENCIA_INSUMOS { get; set; }
    }
}
