namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RESPONSAVEL_TECNICO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long RTE_Cpf { get; set; }

        [Required]
        [StringLength(100)]
        public string RTE_Email { get; set; }

        [Required]
        [StringLength(20)]
        public string RTE_Senha { get; set; }

        [StringLength(15)]
        public string RTE_CRF { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RTE_DataEmissao { get; set; }

        [StringLength(2)]
        public string RTE_CRFEstado { get; set; }

        [StringLength(50)]
        public string RTE_Nome { get; set; }
    }
}
