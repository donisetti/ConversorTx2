namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHEQUE_SACADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHEQUE_SACADO()
        {
            CHEQUE = new HashSet<CHEQUE>();
            CHEQUE_TELEFONE_SACADO = new HashSet<CHEQUE_TELEFONE_SACADO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SAC_Codigo { get; set; }

        [StringLength(50)]
        public string SAC_Nome { get; set; }

        [StringLength(15)]
        public string SAC_CPF_CNPJ { get; set; }

        [StringLength(15)]
        public string SAC_ContaCorrente { get; set; }

        [StringLength(15)]
        public string SAC_Agencia { get; set; }

        public short? BAN_Codigo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHEQUE> CHEQUE { get; set; }

        public virtual CHEQUE_BANCO CHEQUE_BANCO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHEQUE_TELEFONE_SACADO> CHEQUE_TELEFONE_SACADO { get; set; }
    }
}
