namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_VEICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SER_VEICULO()
        {
            SER_SERVICO = new HashSet<SER_SERVICO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VEI_Codigo { get; set; }

        public DateTime? VEI_DataCadastro { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? VEI_DataExclusao { get; set; }

        [StringLength(4)]
        public string VEI_Ano { get; set; }

        [StringLength(7)]
        public string VEI_Placa { get; set; }

        public int PES_Codigo { get; set; }

        public short CAR_Codigo { get; set; }

        public short COR_Codigo { get; set; }

        [StringLength(10)]
        public string VEI_Frota { get; set; }

        [StringLength(30)]
        public string VEI_Serie { get; set; }

        public virtual SER_CARRO SER_CARRO { get; set; }

        public virtual SER_COR SER_COR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_SERVICO> SER_SERVICO { get; set; }
    }
}
