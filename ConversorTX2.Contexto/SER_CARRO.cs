namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_CARRO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SER_CARRO()
        {
            SER_VEICULO = new HashSet<SER_VEICULO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CAR_Codigo { get; set; }

        [Required]
        [StringLength(30)]
        public string CAR_Descricao { get; set; }

        public short MON_Codigo { get; set; }

        public virtual SER_MONTADORA SER_MONTADORA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_VEICULO> SER_VEICULO { get; set; }
    }
}
