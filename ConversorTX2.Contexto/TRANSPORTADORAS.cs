namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRANSPORTADORAS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short TRA_Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string TRA_RazaoSocial { get; set; }

        [Required]
        [StringLength(50)]
        public string TRA_Fantasia { get; set; }

        [Required]
        [StringLength(15)]
        public string TRA_Cnpj { get; set; }

        [StringLength(15)]
        public string TRA_InscricaoEstadual { get; set; }

        [Required]
        [StringLength(50)]
        public string TRA_Endereco { get; set; }

        [Required]
        [StringLength(5)]
        public string TRA_Numero { get; set; }

        [StringLength(22)]
        public string TRA_Complemento { get; set; }

        [Required]
        [StringLength(50)]
        public string TRA_Cidade { get; set; }

        [StringLength(50)]
        public string TRA_Bairro { get; set; }

        [Required]
        [StringLength(3)]
        public string TRA_UF { get; set; }

        [StringLength(9)]
        public string TRA_CEP { get; set; }

        [StringLength(15)]
        public string TRA_Fone1 { get; set; }

        [StringLength(15)]
        public string TRA_Fone2 { get; set; }

        [StringLength(50)]
        public string TRA_Contato { get; set; }
    }
}
