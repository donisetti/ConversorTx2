namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENDERECO_ENTREGA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ETG_Codigo { get; set; }

        public int PES_Codigo { get; set; }

        [Required]
        [StringLength(100)]
        public string ETG_Endereco { get; set; }

        [StringLength(50)]
        public string ETG_Complemento { get; set; }

        [StringLength(80)]
        public string ETG_Bairro { get; set; }

        [StringLength(40)]
        public string ETG_Cidade { get; set; }

        [StringLength(9)]
        public string ETG_Cep { get; set; }

        [StringLength(3)]
        public string ETG_Uf { get; set; }

        public bool? ETG_EntregarNeste { get; set; }

        public long? VDA_Codigo { get; set; }

        [StringLength(50)]
        public string VDA_NomeCliente { get; set; }

        [StringLength(15)]
        public string ETG_Fone { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        public virtual VENDA VENDA { get; set; }
    }
}
