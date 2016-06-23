namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_SERVICO_PARTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SER_SERVICO_PARTE()
        {
            ITENS_VENDA = new HashSet<ITENS_VENDA>();
            SER_SERVICO_PARTE_TECNICO = new HashSet<SER_SERVICO_PARTE_TECNICO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SERPAR_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SERPAR_DataMovimento { get; set; }

        [StringLength(200)]
        public string SERPAR_DefeitoReclamado { get; set; }

        [StringLength(200)]
        public string SERPAR_SolucaoDefeito { get; set; }

        public int SER_Codigo { get; set; }

        public short PAR_Codigo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITENS_VENDA> ITENS_VENDA { get; set; }

        public virtual SER_PARTE SER_PARTE { get; set; }

        public virtual SER_SERVICO SER_SERVICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_SERVICO_PARTE_TECNICO> SER_SERVICO_PARTE_TECNICO { get; set; }
    }
}
