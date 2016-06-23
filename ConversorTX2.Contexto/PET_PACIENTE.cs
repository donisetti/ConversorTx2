namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PET_PACIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PET_PACIENTE()
        {
            PET_CONSULTA = new HashSet<PET_CONSULTA>();
            PET_VACINACAO = new HashSet<PET_VACINACAO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PAC_Codigo { get; set; }

        [StringLength(50)]
        public string PAC_Nome { get; set; }

        public short PEL_Codigo { get; set; }

        [StringLength(100)]
        public string PAC_Descricao { get; set; }

        [StringLength(1)]
        public string PAC_Sexo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PAC_DataNascimento { get; set; }

        [StringLength(30)]
        public string PAC_Idade { get; set; }

        [StringLength(100)]
        public string PAC_Foto { get; set; }

        public int? PES_Codigo { get; set; }

        public short? ESP_Codigo { get; set; }

        public short? RAC_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PAC_DataExclusao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PET_CONSULTA> PET_CONSULTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PET_VACINACAO> PET_VACINACAO { get; set; }
    }
}
