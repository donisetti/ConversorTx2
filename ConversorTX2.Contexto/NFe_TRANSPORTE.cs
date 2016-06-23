namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFe_TRANSPORTE
    {
        [Key]
        [StringLength(9)]
        public string NFe_Numero { get; set; }

        public int NTRA_Codigo { get; set; }

        [StringLength(2)]
        public string NTRA_ModalidadeFrete { get; set; }

        [StringLength(10)]
        public string NTRA_PlacaVeiculo { get; set; }

        [StringLength(2)]
        public string NTRA_UF_Placa { get; set; }

        [StringLength(20)]
        public string NTRA_CodigoANTT { get; set; }

        [StringLength(10)]
        public string NTRA_Quantidade { get; set; }

        [StringLength(50)]
        public string NTRA_Marca { get; set; }

        [StringLength(20)]
        public string NTRA_Numero { get; set; }

        public decimal? NTRA_PesoBruto { get; set; }

        public decimal? NTRA_PesoLiquido { get; set; }
    }
}
