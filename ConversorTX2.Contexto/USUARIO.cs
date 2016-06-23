namespace ConversorTX2.Contexto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USUARIO")]
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            CHEQUE = new HashSet<CHEQUE>();
            COPS_MOVIMENTO = new HashSet<COPS_MOVIMENTO>();
            DEVOLUCAO = new HashSet<DEVOLUCAO>();
            ENTRADA = new HashSet<ENTRADA>();
            SER_COMPRA = new HashSet<SER_COMPRA>();
            SER_SERVICO = new HashSet<SER_SERVICO>();
            SER_SERVICO_PARTE_TECNICO = new HashSet<SER_SERVICO_PARTE_TECNICO>();
            VENDA = new HashSet<VENDA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short USR_Codigo { get; set; }

        [Required]
        [StringLength(20)]
        public string USR_Login { get; set; }

        [StringLength(15)]
        public string USR_Senha { get; set; }

        [StringLength(1)]
        public string USR_Status { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? USR_DtInclusao { get; set; }

        public int PES_Codigo { get; set; }

        [StringLength(15)]
        public string FPO_LoginVendedorCPF { get; set; }

        [StringLength(50)]
        public string FPO_SenhaVendedor { get; set; }

        public DateTime? USR_DtAlteracao { get; set; }

        public short? USR_UsuarioIncluiu { get; set; }

        public short? USR_UsuarioAlterou { get; set; }

        [StringLength(1)]
        public string USR_NivelAcesso { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHEQUE> CHEQUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COPS_MOVIMENTO> COPS_MOVIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEVOLUCAO> DEVOLUCAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTRADA> ENTRADA { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_COMPRA> SER_COMPRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_SERVICO> SER_SERVICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SER_SERVICO_PARTE_TECNICO> SER_SERVICO_PARTE_TECNICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA> VENDA { get; set; }
    }
}
