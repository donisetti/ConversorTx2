namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COPS_MOVIMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COPS_MOVIMENTO()
        {
            COPS_MOVIMENTO_ITENS = new HashSet<COPS_MOVIMENTO_ITENS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MOV_Codigo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime MOV_DataLancamento { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MOV_DataReceita { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MOV_DataEstorno { get; set; }

        public int PES_Codigo { get; set; }

        public int? MED_Codigo { get; set; }

        public short USU_Codigo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COPS_MOVIMENTO_ITENS> COPS_MOVIMENTO_ITENS { get; set; }

        public virtual MEDICOS MEDICOS { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
