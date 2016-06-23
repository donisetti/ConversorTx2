namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLASSIFICACAO")]
    public partial class CLASSIFICACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLASSIFICACAO()
        {
            PRODUTO = new HashSet<PRODUTO>();
            PESSOA_CLASSIFICACAO = new HashSet<PESSOA_CLASSIFICACAO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CLA_Codigo { get; set; }

        [Required]
        [StringLength(30)]
        public string CLA_Descricao { get; set; }

        public decimal? CLA_Pct_DescAVista { get; set; }

        public DateTime? CLA_Dta_InicioDescAVista { get; set; }

        public DateTime? CLA_Dta_FinalDescAVista { get; set; }

        [StringLength(1)]
        public string CLA_DescAVistaAtivo { get; set; }

        public decimal? CLA_Pct_DescAPrazo { get; set; }

        public DateTime? CLA_Dta_InicioDescAPrazo { get; set; }

        public DateTime? CLA_Dta_FinalDescAPrazo { get; set; }

        [StringLength(1)]
        public string CLA_DescAPrazoAtivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO> PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PESSOA_CLASSIFICACAO> PESSOA_CLASSIFICACAO { get; set; }
    }
}
