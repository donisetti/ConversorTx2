namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_EQUIPAMENTO_MODELO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SER_EQUIPAMENTO_MODELO()
        {
            SER_EQUIPAMENTO_NOME = new HashSet<SER_EQUIPAMENTO_NOME>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EQUIMOD_Codigo { get; set; }

        [StringLength(50)]
        public string EQUIMOD_Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_EQUIPAMENTO_NOME> SER_EQUIPAMENTO_NOME { get; set; }
    }
}
