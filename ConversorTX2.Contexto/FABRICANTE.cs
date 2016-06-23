namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FABRICANTE")]
    public partial class FABRICANTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FABRICANTE()
        {
            PRODUTO = new HashSet<PRODUTO>();
            FABRICANTE_DISTRIBUIDORA = new HashSet<FABRICANTE_DISTRIBUIDORA>();
            PRODUTO1 = new HashSet<PRODUTO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FAB_Codigo { get; set; }

        [Required]
        [StringLength(30)]
        public string FAB_Descricao { get; set; }

        [StringLength(40)]
        public string FAB_Endereco { get; set; }

        [StringLength(30)]
        public string FAB_Complemento { get; set; }

        [StringLength(30)]
        public string FAB_Cidade { get; set; }

        [StringLength(3)]
        public string FAB_Estado { get; set; }

        [StringLength(12)]
        public string FAB_Cep { get; set; }

        [StringLength(100)]
        public string FAB_Telefone { get; set; }

        [StringLength(200)]
        public string FAB_EMAIL { get; set; }

        public long? FAB_CodigoFAI { get; set; }

        [StringLength(30)]
        public string FAB_Bairro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO> PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FABRICANTE_DISTRIBUIDORA> FABRICANTE_DISTRIBUIDORA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO> PRODUTO1 { get; set; }
    }
}
