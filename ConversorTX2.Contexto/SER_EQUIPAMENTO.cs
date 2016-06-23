namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SER_EQUIPAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SER_EQUIPAMENTO()
        {
            SER_EQUIPAMENTO_SERVICO = new HashSet<SER_EQUIPAMENTO_SERVICO>();
            SER_SERVICO = new HashSet<SER_SERVICO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EQUI_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EQUI_DataCadastro { get; set; }

        [StringLength(50)]
        public string EQUI_Serial { get; set; }

        public int? PES_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EQUI_DataExclusao { get; set; }

        public int? EQUINOM_Codigo { get; set; }

        public short? COR_Codigo { get; set; }

        public decimal? EQUI_ValorImobilizado { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        public virtual SER_COR SER_COR { get; set; }

        public virtual SER_EQUIPAMENTO_NOME SER_EQUIPAMENTO_NOME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_EQUIPAMENTO_SERVICO> SER_EQUIPAMENTO_SERVICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_SERVICO> SER_SERVICO { get; set; }
    }
}
