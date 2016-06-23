namespace ConversorTX2.Contexto
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContexto : DbContext
    {
        public DBContexto()
            : base("name=DBContexto")
        {
        }

        public virtual DbSet<BACKUPS> BACKUPS { get; set; }
        public virtual DbSet<BULARIO> BULARIO { get; set; }
        public virtual DbSet<CAIXA_CONTROLE> CAIXA_CONTROLE { get; set; }
        public virtual DbSet<CAIXA_LANCAMENTO> CAIXA_LANCAMENTO { get; set; }
        public virtual DbSet<CAIXA_OPERADOR> CAIXA_OPERADOR { get; set; }
        public virtual DbSet<CATEGORIA> CATEGORIA { get; set; }
        public virtual DbSet<CHEQUE> CHEQUE { get; set; }
        public virtual DbSet<CHEQUE_BANCO> CHEQUE_BANCO { get; set; }
        public virtual DbSet<CHEQUE_SACADO> CHEQUE_SACADO { get; set; }
        public virtual DbSet<CHEQUE_STATUS> CHEQUE_STATUS { get; set; }
        public virtual DbSet<CHEQUE_TELEFONE_SACADO> CHEQUE_TELEFONE_SACADO { get; set; }
        public virtual DbSet<CLASSE_TERAPEUTICA> CLASSE_TERAPEUTICA { get; set; }
        public virtual DbSet<CLASSIFICACAO> CLASSIFICACAO { get; set; }
        public virtual DbSet<CONSELHO_PROFISSIONAL> CONSELHO_PROFISSIONAL { get; set; }
        public virtual DbSet<CONSIGNADO> CONSIGNADO { get; set; }
        public virtual DbSet<CONTAS_RECEBER> CONTAS_RECEBER { get; set; }
        public virtual DbSet<CONTAS_RECEBIMENTO> CONTAS_RECEBIMENTO { get; set; }
        public virtual DbSet<CONVENIO> CONVENIO { get; set; }
        public virtual DbSet<COPS_MOVIMENTO> COPS_MOVIMENTO { get; set; }
        public virtual DbSet<COPS_MOVIMENTO_ITENS> COPS_MOVIMENTO_ITENS { get; set; }
        public virtual DbSet<DEVOLUCAO> DEVOLUCAO { get; set; }
        public virtual DbSet<DEVOLUCAO_ITEM> DEVOLUCAO_ITEM { get; set; }
        public virtual DbSet<DISTRIBUIDORA> DISTRIBUIDORA { get; set; }
        public virtual DbSet<DOCUMENTO_CLIENTES> DOCUMENTO_CLIENTES { get; set; }
        public virtual DbSet<EMPRESAS_GRUPO> EMPRESAS_GRUPO { get; set; }
        public virtual DbSet<ENDERECO_ENTREGA> ENDERECO_ENTREGA { get; set; }
        public virtual DbSet<ENTRADA> ENTRADA { get; set; }
        public virtual DbSet<ENTRADA_INSUMOS> ENTRADA_INSUMOS { get; set; }
        public virtual DbSet<ENTRADA_ITEM> ENTRADA_ITEM { get; set; }
        public virtual DbSet<ENTRADA_PRODUTOS> ENTRADA_PRODUTOS { get; set; }
        public virtual DbSet<ENTRADA_UNIDADE_MEDIDA> ENTRADA_UNIDADE_MEDIDA { get; set; }
        public virtual DbSet<ENTREGA_EFETUADA> ENTREGA_EFETUADA { get; set; }
        public virtual DbSet<ESTADO> ESTADO { get; set; }
        public virtual DbSet<ESTOQUE_CLIENTE> ESTOQUE_CLIENTE { get; set; }
        public virtual DbSet<FABRICANTE> FABRICANTE { get; set; }
        public virtual DbSet<FABRICANTE_DISTRIBUIDORA> FABRICANTE_DISTRIBUIDORA { get; set; }
        public virtual DbSet<FARMACOLOGIA> FARMACOLOGIA { get; set; }
        public virtual DbSet<FISICA> FISICA { get; set; }
        public virtual DbSet<FORMA_PAGAMENTO> FORMA_PAGAMENTO { get; set; }
        public virtual DbSet<FORMA_PAGAMENTO_IMPRESSORA> FORMA_PAGAMENTO_IMPRESSORA { get; set; }
        public virtual DbSet<FORNECEDORES> FORNECEDORES { get; set; }
        public virtual DbSet<GRUPO> GRUPO { get; set; }
        public virtual DbSet<IMPRESSAO_ETIQUETAS_TEMP> IMPRESSAO_ETIQUETAS_TEMP { get; set; }
        public virtual DbSet<IMPRESSORA> IMPRESSORA { get; set; }
        public virtual DbSet<IMPRESSORA_MATRICIAL> IMPRESSORA_MATRICIAL { get; set; }
        public virtual DbSet<ITENS_CONSIGNADO> ITENS_CONSIGNADO { get; set; }
        public virtual DbSet<ITENS_ORCAMENTO> ITENS_ORCAMENTO { get; set; }
        public virtual DbSet<ITENS_VENDA> ITENS_VENDA { get; set; }
        public virtual DbSet<JURIDICA> JURIDICA { get; set; }
        public virtual DbSet<LINHA_PRODUTO> LINHA_PRODUTO { get; set; }
        public virtual DbSet<LOTE> LOTE { get; set; }
        public virtual DbSet<MEDICOS> MEDICOS { get; set; }
        public virtual DbSet<NFCe_CONTINGENCIA> NFCe_CONTINGENCIA { get; set; }
        public virtual DbSet<NFCe_INFNOTAFISCAL> NFCe_INFNOTAFISCAL { get; set; }
        public virtual DbSet<NFe_CFOP> NFe_CFOP { get; set; }
        public virtual DbSet<NFe_CFOP_CORRESPONDENCIA> NFe_CFOP_CORRESPONDENCIA { get; set; }
        public virtual DbSet<NFe_DUPLICATA> NFe_DUPLICATA { get; set; }
        public virtual DbSet<NFe_FATURA> NFe_FATURA { get; set; }
        public virtual DbSet<NFe_INFNOTAFISCAL> NFe_INFNOTAFISCAL { get; set; }
        public virtual DbSet<NFe_NOTA_CUPOM> NFe_NOTA_CUPOM { get; set; }
        public virtual DbSet<NFe_ST_COFINS> NFe_ST_COFINS { get; set; }
        public virtual DbSet<NFe_ST_ICMS> NFe_ST_ICMS { get; set; }
        public virtual DbSet<NFe_ST_ICMS_CORRESPONDENCIA> NFe_ST_ICMS_CORRESPONDENCIA { get; set; }
        public virtual DbSet<NFe_ST_IPI> NFe_ST_IPI { get; set; }
        public virtual DbSet<NFe_ST_PIS> NFe_ST_PIS { get; set; }
        public virtual DbSet<NFe_TRANSPORTE> NFe_TRANSPORTE { get; set; }
        public virtual DbSet<ORCAMENTO> ORCAMENTO { get; set; }
        public virtual DbSet<ORDEM_SERVICO_PRODUTOS_ORDEM> ORDEM_SERVICO_PRODUTOS_ORDEM { get; set; }
        public virtual DbSet<ORGAO_EXPEDIDOR> ORGAO_EXPEDIDOR { get; set; }
        public virtual DbSet<PAF_DETALHE_REDUCAO_Z> PAF_DETALHE_REDUCAO_Z { get; set; }
        public virtual DbSet<PAF_RELACAO_REDUCAO_Z> PAF_RELACAO_REDUCAO_Z { get; set; }
        public virtual DbSet<PARAMETROS_FAI> PARAMETROS_FAI { get; set; }
        public virtual DbSet<PARAMETROS_TEF> PARAMETROS_TEF { get; set; }
        public virtual DbSet<PERDA_INSUMOS> PERDA_INSUMOS { get; set; }
        public virtual DbSet<PERDA_PRODUTOS> PERDA_PRODUTOS { get; set; }
        public virtual DbSet<PERFIL> PERFIL { get; set; }
        public virtual DbSet<PERIODICIDADE> PERIODICIDADE { get; set; }
        public virtual DbSet<PESSOA> PESSOA { get; set; }
        public virtual DbSet<PESSOA_CLASSIFICACAO> PESSOA_CLASSIFICACAO { get; set; }
        public virtual DbSet<PET_CONSULTA> PET_CONSULTA { get; set; }
        public virtual DbSet<PET_CONSULTA_ITEM_nao_usar> PET_CONSULTA_ITEM_nao_usar { get; set; }
        public virtual DbSet<PET_CONSULTA_SERVICO_nao_usar> PET_CONSULTA_SERVICO_nao_usar { get; set; }
        public virtual DbSet<PET_ESPECIE> PET_ESPECIE { get; set; }
        public virtual DbSet<PET_FICHA_RECEITUARIO> PET_FICHA_RECEITUARIO { get; set; }
        public virtual DbSet<PET_PACIENTE> PET_PACIENTE { get; set; }
        public virtual DbSet<PET_PELAGEM> PET_PELAGEM { get; set; }
        public virtual DbSet<PET_RACA> PET_RACA { get; set; }
        public virtual DbSet<PET_SERVICO_NAO_USARMAIS> PET_SERVICO_NAO_USARMAIS { get; set; }
        public virtual DbSet<PET_TIPO_RETORNO_VACINA> PET_TIPO_RETORNO_VACINA { get; set; }
        public virtual DbSet<PET_VACINA> PET_VACINA { get; set; }
        public virtual DbSet<PET_VACINACAO> PET_VACINACAO { get; set; }
        public virtual DbSet<PLANO_CONTAS> PLANO_CONTAS { get; set; }
        public virtual DbSet<PRODUTO> PRODUTO { get; set; }
        public virtual DbSet<PRODUTO_INVENTARIO> PRODUTO_INVENTARIO { get; set; }
        public virtual DbSet<PSICO_CLIENTE> PSICO_CLIENTE { get; set; }
        public virtual DbSet<PSICO_CONFIGURACOES> PSICO_CONFIGURACOES { get; set; }
        public virtual DbSet<REGISTRO_ECF> REGISTRO_ECF { get; set; }
        public virtual DbSet<RESPONSAVEL_TECNICO> RESPONSAVEL_TECNICO { get; set; }
        public virtual DbSet<SAIDA_INSUMOS> SAIDA_INSUMOS { get; set; }
        public virtual DbSet<SAIDA_PRODUTOS> SAIDA_PRODUTOS { get; set; }
        public virtual DbSet<SER_CARRO> SER_CARRO { get; set; }
        public virtual DbSet<SER_COMPRA> SER_COMPRA { get; set; }
        public virtual DbSet<SER_COMPRA_ITEM> SER_COMPRA_ITEM { get; set; }
        public virtual DbSet<SER_COR> SER_COR { get; set; }
        public virtual DbSet<SER_EQUIPAMENTO> SER_EQUIPAMENTO { get; set; }
        public virtual DbSet<SER_EQUIPAMENTO_MODELO> SER_EQUIPAMENTO_MODELO { get; set; }
        public virtual DbSet<SER_EQUIPAMENTO_NOME> SER_EQUIPAMENTO_NOME { get; set; }
        public virtual DbSet<SER_EQUIPAMENTO_SERVICO> SER_EQUIPAMENTO_SERVICO { get; set; }
        public virtual DbSet<SER_FUNCIONARIO> SER_FUNCIONARIO { get; set; }
        public virtual DbSet<SER_MONTADORA> SER_MONTADORA { get; set; }
        public virtual DbSet<SER_PARTE> SER_PARTE { get; set; }
        public virtual DbSet<SER_SERVICO> SER_SERVICO { get; set; }
        public virtual DbSet<SER_SERVICO_PARTE> SER_SERVICO_PARTE { get; set; }
        public virtual DbSet<SER_SERVICO_PARTE_TECNICO> SER_SERVICO_PARTE_TECNICO { get; set; }
        public virtual DbSet<SER_STATUS> SER_STATUS { get; set; }
        public virtual DbSet<SER_TIPO_SERVICO> SER_TIPO_SERVICO { get; set; }
        public virtual DbSet<SER_VEICULO> SER_VEICULO { get; set; }
        public virtual DbSet<SUBSTANCIA> SUBSTANCIA { get; set; }
        public virtual DbSet<SUBSTANCIA_PRODUTO> SUBSTANCIA_PRODUTO { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TIPO_DOCUMENTOS> TIPO_DOCUMENTOS { get; set; }
        public virtual DbSet<TIPO_MOTIVO_PERDA> TIPO_MOTIVO_PERDA { get; set; }
        public virtual DbSet<TIPO_NOTAFISCAL> TIPO_NOTAFISCAL { get; set; }
        public virtual DbSet<TIPO_PRODUTO> TIPO_PRODUTO { get; set; }
        public virtual DbSet<TIPO_RECEITUARIO> TIPO_RECEITUARIO { get; set; }
        public virtual DbSet<TIPO_UNIDADE_FARMACOTECNICA> TIPO_UNIDADE_FARMACOTECNICA { get; set; }
        public virtual DbSet<TIPO_UNIDADE_INSUMO> TIPO_UNIDADE_INSUMO { get; set; }
        public virtual DbSet<TIPO_USO_MEDICAMENTO> TIPO_USO_MEDICAMENTO { get; set; }
        public virtual DbSet<TIPO_VENDA> TIPO_VENDA { get; set; }
        public virtual DbSet<TRANSFERENCIA_INSUMOS> TRANSFERENCIA_INSUMOS { get; set; }
        public virtual DbSet<TRANSFERENCIA_PRODUTOS> TRANSFERENCIA_PRODUTOS { get; set; }
        public virtual DbSet<TRANSPORTADORAS> TRANSPORTADORAS { get; set; }
        public virtual DbSet<TRIBUTACAO> TRIBUTACAO { get; set; }
        public virtual DbSet<UNIDADE_MEDIDA> UNIDADE_MEDIDA { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<VENDA> VENDA { get; set; }
        public virtual DbSet<VENDA_LOTE> VENDA_LOTE { get; set; }
        public virtual DbSet<VENDA_PAGAMENTO> VENDA_PAGAMENTO { get; set; }
        public virtual DbSet<IMPRESSAO_ETIQUETAS> IMPRESSAO_ETIQUETAS { get; set; }
        public virtual DbSet<NFe_IBGE_CIDADE> NFe_IBGE_CIDADE { get; set; }
        public virtual DbSet<NFe_IBPTAX_Tabela> NFe_IBPTAX_Tabela { get; set; }
        public virtual DbSet<PARAMETROS_FPOPULAR> PARAMETROS_FPOPULAR { get; set; }
        public virtual DbSet<USUARIO_ACESSO> USUARIO_ACESSO { get; set; }
        public virtual DbSet<VENDA_CPF_CNPJ> VENDA_CPF_CNPJ { get; set; }
        public virtual DbSet<ConsultaVendas> ConsultaVendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_IPServidor)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_NomeEstacao)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_ImpressoraConfigurada)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_ModeloImpressoraCodigoBarras)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_QuantidadeLinhaCupom40)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_QuantidadeLinhaCupom80)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_ModeloCupom_MATRICIAL_HP)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_ModeloOrcamento_MATRICIAL_HP)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_ViasReimpressao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_NomePortaSerial)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_Paridade)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_StopBits)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_ImpressoraConfiguradaEtiqueta)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_ModeloEtiqueta)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_NomeBalancaCheckout)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_ModeloCupomConsignado_MATRICIAL_HP)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_PortaSerialECF)
                .IsUnicode(false);

            modelBuilder.Entity<BACKUPS>()
                .Property(e => e.BAK_IMPFisicaPortaCom)
                .IsUnicode(false);

            modelBuilder.Entity<BULARIO>()
                .Property(e => e.BUL_Bula)
                .IsUnicode(false);

            modelBuilder.Entity<CAIXA_CONTROLE>()
                .Property(e => e.CXC_ValorEntrada)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CAIXA_CONTROLE>()
                .Property(e => e.CXC_SaldoInicial)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CAIXA_CONTROLE>()
                .Property(e => e.CXC_SaldoFinal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CAIXA_CONTROLE>()
                .Property(e => e.CXC_SaldoMovimentacao)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CAIXA_CONTROLE>()
                .Property(e => e.CXC_SaldoContasReceber)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CAIXA_LANCAMENTO>()
                .Property(e => e.CXL_ValorLancamento)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CAIXA_LANCAMENTO>()
                .Property(e => e.CXL_Historico)
                .IsUnicode(false);

            modelBuilder.Entity<CAIXA_OPERADOR>()
                .Property(e => e.CXO_ValorEntrada)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CAIXA_OPERADOR>()
                .Property(e => e.CXO_SaldoFinal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CATEGORIA>()
                .Property(e => e.CAT_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE>()
                .Property(e => e.CHE_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE>()
                .Property(e => e.CHE_Valor)
                .HasPrecision(15, 3);

            modelBuilder.Entity<CHEQUE>()
                .Property(e => e.CHE_Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE_BANCO>()
                .Property(e => e.BAN_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE_BANCO>()
                .Property(e => e.BAN_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE_SACADO>()
                .Property(e => e.SAC_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE_SACADO>()
                .Property(e => e.SAC_CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE_SACADO>()
                .Property(e => e.SAC_ContaCorrente)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE_SACADO>()
                .Property(e => e.SAC_Agencia)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE_SACADO>()
                .HasMany(e => e.CHEQUE)
                .WithRequired(e => e.CHEQUE_SACADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHEQUE_STATUS>()
                .Property(e => e.STS_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE_STATUS>()
                .Property(e => e.STS_Sigla)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE_TELEFONE_SACADO>()
                .Property(e => e.TES_Area)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE_TELEFONE_SACADO>()
                .Property(e => e.TES_Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<CLASSE_TERAPEUTICA>()
                .Property(e => e.CLAT_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<CLASSIFICACAO>()
                .Property(e => e.CLA_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<CLASSIFICACAO>()
                .Property(e => e.CLA_Pct_DescAVista)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CLASSIFICACAO>()
                .Property(e => e.CLA_DescAVistaAtivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLASSIFICACAO>()
                .Property(e => e.CLA_Pct_DescAPrazo)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CLASSIFICACAO>()
                .Property(e => e.CLA_DescAPrazoAtivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONSELHO_PROFISSIONAL>()
                .Property(e => e.CAL_Sigla)
                .IsUnicode(false);

            modelBuilder.Entity<CONSELHO_PROFISSIONAL>()
                .Property(e => e.CAL_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<CONSELHO_PROFISSIONAL>()
                .HasMany(e => e.MEDICOS)
                .WithRequired(e => e.CONSELHO_PROFISSIONAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONSIGNADO>()
                .Property(e => e.CDO_Valor)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CONTAS_RECEBER>()
                .Property(e => e.CRE_ValorPagamento)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CONTAS_RECEBER>()
                .Property(e => e.CRE_ValorAbatido)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CONTAS_RECEBER>()
                .Property(e => e.CRE_ValorBruto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CONTAS_RECEBER>()
                .Property(e => e.CRE_Situacao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTAS_RECEBER>()
                .Property(e => e.CRE_ValorJurosAbatidos)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CONTAS_RECEBER>()
                .Property(e => e.CRE_ValorJurosRestantes)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CONTAS_RECEBER>()
                .Property(e => e.VDA_ValorCredito)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CONTAS_RECEBER>()
                .Property(e => e.CRE_ParcelaTexto)
                .IsUnicode(false);

            modelBuilder.Entity<CONTAS_RECEBER>()
                .Property(e => e.CRE_ValorDescontoRecebimento)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CONTAS_RECEBER>()
                .Property(e => e.CRE_PctDescontoRecebimento)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CONTAS_RECEBER>()
                .HasMany(e => e.CONTAS_RECEBIMENTO)
                .WithRequired(e => e.CONTAS_RECEBER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTAS_RECEBIMENTO>()
                .Property(e => e.COR_ValorRecebido)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CONTAS_RECEBIMENTO>()
                .Property(e => e.COR_ValorJurosRecebidos)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CONTAS_RECEBIMENTO>()
                .Property(e => e.COR_ValorDesconto)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CONTAS_RECEBIMENTO>()
                .Property(e => e.COR_ValorAbatido)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CONTAS_RECEBIMENTO>()
                .Property(e => e.COR_JuroAbatido)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CONTAS_RECEBIMENTO>()
                .Property(e => e.COR_JuroRestante)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_PctDesconto)
                .HasPrecision(5, 2);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_CobrarJuros)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_LimiteCredito)
                .HasPrecision(15, 2);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_Fone)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_Municipio)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_UF)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_Contato)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_Email)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CVN_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<COPS_MOVIMENTO>()
                .HasMany(e => e.COPS_MOVIMENTO_ITENS)
                .WithRequired(e => e.COPS_MOVIMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COPS_MOVIMENTO_ITENS>()
                .Property(e => e.IMO_Quantidade)
                .HasPrecision(10, 3);

            modelBuilder.Entity<DEVOLUCAO>()
                .Property(e => e.DEV_ValorDevolucao)
                .HasPrecision(15, 2);

            modelBuilder.Entity<DEVOLUCAO_ITEM>()
                .Property(e => e.DVI_Quantidade)
                .HasPrecision(10, 3);

            modelBuilder.Entity<DEVOLUCAO_ITEM>()
                .Property(e => e.DVI_ValorUnitario)
                .HasPrecision(15, 2);

            modelBuilder.Entity<DEVOLUCAO_ITEM>()
                .Property(e => e.DVI_DescontoItemPct)
                .HasPrecision(15, 2);

            modelBuilder.Entity<DISTRIBUIDORA>()
                .Property(e => e.DIS_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<DISTRIBUIDORA>()
                .HasMany(e => e.FABRICANTE_DISTRIBUIDORA)
                .WithRequired(e => e.DISTRIBUIDORA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOCUMENTO_CLIENTES>()
                .Property(e => e.DCLI_Numero_Documento)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTO_CLIENTES>()
                .Property(e => e.DCLI_UFEmissaoDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_UF)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Razao)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Fone)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Fax)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_SaldoContaCaixa)
                .HasPrecision(15, 2);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Contato)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_InscricaoEstadual)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_DadosAdicionais)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_SenhaProxy)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_UsuarioProxy)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_VersaoSchema)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_ModeloNF)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_CertificadoDigital)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_UsuarioSmtp)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_LicencaDLL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_WebService_UF_Emitente)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_LocalLogoMarca)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_NomeServidorSmtp)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_SenhaSmtp)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_EmailSmtp)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_MensagemPadraoSmtp)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_TipoCertificado)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Proxy)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_IM)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_CNAE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_UltimaNota)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_AliqICMSSN)
                .HasPrecision(5, 2);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_EmailContador)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Aliquota_PIS)
                .HasPrecision(5, 2);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Aliquota_COFINS)
                .HasPrecision(5, 2);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_Perfil)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_NomeContador)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_CPFContador)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_CrcContador)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_ModeloNFCe)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_UltimaNotaNFCe)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_WebService_UF_EmitenteNFCe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_VersaoSchemaNFCe)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_IdToken)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAS_GRUPO>()
                .Property(e => e.EMP_CSC)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_ENTREGA>()
                .Property(e => e.ETG_Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_ENTREGA>()
                .Property(e => e.ETG_Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_ENTREGA>()
                .Property(e => e.ETG_Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_ENTREGA>()
                .Property(e => e.ETG_Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_ENTREGA>()
                .Property(e => e.ETG_Cep)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_ENTREGA>()
                .Property(e => e.ETG_Uf)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_ENTREGA>()
                .Property(e => e.VDA_NomeCliente)
                .IsUnicode(false);

            modelBuilder.Entity<ENDERECO_ENTREGA>()
                .Property(e => e.ETG_Fone)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA>()
                .Property(e => e.ENT_NotaFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA>()
                .Property(e => e.ENT_ValorNota)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA>()
                .Property(e => e.ENT_ValorIpiEntrada)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA>()
                .Property(e => e.ENT_ValorFrete)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA>()
                .Property(e => e.ENT_ValorSubEntrada)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA>()
                .Property(e => e.ENT_ValorProdutos)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA>()
                .Property(e => e.ENT_ChNFe)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA>()
                .Property(e => e.ENT_ValorSeguro)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA>()
                .Property(e => e.ENT_ValorDesconto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA>()
                .Property(e => e.ENT_Serie)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA>()
                .Property(e => e.ENT_Xml)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA_INSUMOS>()
                .Property(e => e.EIS_NumeroNF)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA_INSUMOS>()
                .Property(e => e.EIS_NumeroLote)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA_INSUMOS>()
                .Property(e => e.EIS_Quantidade)
                .HasPrecision(5, 1);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_Quantidade)
                .HasPrecision(10, 3);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_ValorCusto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_IpiEntrada)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_ValorFreteUnitario)
                .HasPrecision(15, 3);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.STICMS_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.CFOP_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_AliqICMS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_BaseCalcICMS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_ValorICMS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_AliqICMSST)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.STIPI_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_BaseCalcIPI)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_AliqIPI)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_ValorIPI)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.STPIS_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_BaseCalcPIS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_ValorPIS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_AliqPIS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.STCOFINS_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_BaseCalcCOFINS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_AliqCOFINS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_ValorCOFINS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_BaseCalcICMSST)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_ValorICMSST)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_ValorDesconto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_ValorTotal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_ITEM>()
                .Property(e => e.ETI_ValorOutrasDespesas)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_PRODUTOS>()
                .Property(e => e.ENT_NumeroNF)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA_PRODUTOS>()
                .Property(e => e.ENT_NumeroLote)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA_PRODUTOS>()
                .Property(e => e.PRO_RegistroMsInventario)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA_UNIDADE_MEDIDA>()
                .Property(e => e.EUN_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRADA_UNIDADE_MEDIDA>()
                .Property(e => e.EUN_FatorSaida)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTRADA_UNIDADE_MEDIDA>()
                .Property(e => e.EUN_FatorEntrada)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ENTREGA_EFETUADA>()
                .Property(e => e.EFE_QuantidadeEntregue)
                .HasPrecision(10, 3);

            modelBuilder.Entity<ESTADO>()
                .Property(e => e.EST_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADO>()
                .Property(e => e.EST_Sigla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_CLIENTE>()
                .Property(e => e.ECL_QuantidadeEntregue)
                .HasPrecision(10, 3);

            modelBuilder.Entity<FABRICANTE>()
                .Property(e => e.FAB_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<FABRICANTE>()
                .Property(e => e.FAB_Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<FABRICANTE>()
                .Property(e => e.FAB_Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<FABRICANTE>()
                .Property(e => e.FAB_Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<FABRICANTE>()
                .Property(e => e.FAB_Estado)
                .IsUnicode(false);

            modelBuilder.Entity<FABRICANTE>()
                .Property(e => e.FAB_Cep)
                .IsUnicode(false);

            modelBuilder.Entity<FABRICANTE>()
                .Property(e => e.FAB_Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<FABRICANTE>()
                .Property(e => e.FAB_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<FABRICANTE>()
                .Property(e => e.FAB_Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<FABRICANTE>()
                .HasMany(e => e.PRODUTO)
                .WithOptional(e => e.FABRICANTE)
                .HasForeignKey(e => e.FAB_Codigo);

            modelBuilder.Entity<FABRICANTE>()
                .HasMany(e => e.FABRICANTE_DISTRIBUIDORA)
                .WithRequired(e => e.FABRICANTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FABRICANTE>()
                .HasMany(e => e.PRODUTO1)
                .WithOptional(e => e.FABRICANTE1)
                .HasForeignKey(e => e.FAB_Codigo);

            modelBuilder.Entity<FABRICANTE_DISTRIBUIDORA>()
                .Property(e => e.PCT_Desconto)
                .HasPrecision(5, 2);

            modelBuilder.Entity<FARMACOLOGIA>()
                .Property(e => e.FIA_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_Rg)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_Cpf)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_NomeMae)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_OrgaoEmissor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_EnderecoComercial)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_LocalTrabalho)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_FoneComercial)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_FoneReferenciaComercial)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_NomePai)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_ReferenciaCom)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_CidadeLocalTrabalho)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_SalarioLocalTrabalho)
                .HasPrecision(10, 2);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_TempoServico)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.Fis_EstadoCivil)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_Residencia)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_NomeConjuge)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_LocalTrabalhoConjuge)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_EnderecoLocalTrabalhoConjuge)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_CidadeLocalTrabalhoConjuge)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_FoneLocalTrabalhoConjuge)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_SalarioConjuge)
                .HasPrecision(10, 2);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_TempoServicoConjuge)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_FuncaoTrabalho)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .Property(e => e.FIS_Natural)
                .IsUnicode(false);

            modelBuilder.Entity<FISICA>()
                .HasMany(e => e.SAIDA_INSUMOS)
                .WithRequired(e => e.FISICA)
                .HasForeignKey(e => e.CLI_Codigo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORMA_PAGAMENTO>()
                .Property(e => e.FPG_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Fantasia)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Rg_InscricaoEstadual)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Cpf_Cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Cep)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Uf)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Email)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_TipoCadastro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDORES>()
                .Property(e => e.FOR_Atividade)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO>()
                .Property(e => e.GRP_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO>()
                .Property(e => e.GRP_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<IMPRESSAO_ETIQUETAS_TEMP>()
                .Property(e => e.ETT_Quantidade)
                .HasPrecision(10, 3);

            modelBuilder.Entity<IMPRESSORA>()
                .Property(e => e.IMP_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<IMPRESSORA>()
                .HasMany(e => e.REGISTRO_ECF)
                .WithRequired(e => e.IMPRESSORA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IMPRESSORA_MATRICIAL>()
                .Property(e => e.IMP_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<ITENS_CONSIGNADO>()
                .Property(e => e.ICD_Quantidade)
                .HasPrecision(10, 3);

            modelBuilder.Entity<ITENS_CONSIGNADO>()
                .Property(e => e.ICD_QuantidadeEstorno)
                .HasPrecision(10, 3);

            modelBuilder.Entity<ITENS_CONSIGNADO>()
                .Property(e => e.ICD_CustoReal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_CONSIGNADO>()
                .Property(e => e.ICD_CustoFabrica)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_CONSIGNADO>()
                .Property(e => e.ICD_ValorVendaUnitario)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_CONSIGNADO>()
                .Property(e => e.ICD_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<ITENS_CONSIGNADO>()
                .Property(e => e.ICD_Apresentacao)
                .IsUnicode(false);

            modelBuilder.Entity<ITENS_ORCAMENTO>()
                .Property(e => e.IOC_Quantidade)
                .HasPrecision(10, 3);

            modelBuilder.Entity<ITENS_ORCAMENTO>()
                .Property(e => e.IOC_QuantidadeEstorno)
                .HasPrecision(10, 3);

            modelBuilder.Entity<ITENS_ORCAMENTO>()
                .Property(e => e.IOC_CustoFabrica)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_ORCAMENTO>()
                .Property(e => e.IOC_ValorVendaUnitario)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_ORCAMENTO>()
                .Property(e => e.IOC_ValorDescontoProduto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_ORCAMENTO>()
                .Property(e => e.IOC_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<ITENS_ORCAMENTO>()
                .Property(e => e.IOC_Apresentacao)
                .IsUnicode(false);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_Quantidade)
                .HasPrecision(10, 3);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_CustoReal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_CustoFabrica)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_ValorVendaUnitario)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_ValorDescontoProduto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_ValorDescontoItemDevolucao)
                .HasPrecision(15, 3);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_ValorVendaFinal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_Lote)
                .IsUnicode(false);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_ComissaoPaga)
                .HasPrecision(15, 0);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_PctComissao)
                .HasPrecision(15, 0);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_QuantidadeEstorno)
                .HasPrecision(10, 3);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_ValorDevolvido)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_ValorDescontoDevolvido)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_PctDescontoProduto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_PctDescontoTotal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.PRO_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.PRO_Apresentacao)
                .IsUnicode(false);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_Historico)
                .IsUnicode(false);

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_CodigoNCM)
                .IsFixedLength();

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_CodExcecao_NCM)
                .IsFixedLength();

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_STICMS)
                .IsFixedLength();

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_Origem_ICMS)
                .IsFixedLength();

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_STIPI)
                .IsFixedLength();

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_STPIS)
                .IsFixedLength();

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_STCOFINS)
                .IsFixedLength();

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_CFOP)
                .IsFixedLength();

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_MsgAdicionais)
                .IsFixedLength();

            modelBuilder.Entity<ITENS_VENDA>()
                .Property(e => e.IVD_RedBaseCalcICMS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<JURIDICA>()
                .Property(e => e.JUR_Cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<JURIDICA>()
                .Property(e => e.JUR_RazaoSocial)
                .IsUnicode(false);

            modelBuilder.Entity<JURIDICA>()
                .Property(e => e.JUR_NomeFantasia)
                .IsUnicode(false);

            modelBuilder.Entity<JURIDICA>()
                .Property(e => e.JUR_InscricaoEstadual)
                .IsUnicode(false);

            modelBuilder.Entity<JURIDICA>()
                .HasMany(e => e.PERDA_INSUMOS)
                .WithRequired(e => e.JURIDICA)
                .HasForeignKey(e => e.FOR_CodigoInsumo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JURIDICA>()
                .HasMany(e => e.SAIDA_INSUMOS)
                .WithRequired(e => e.JURIDICA)
                .HasForeignKey(e => e.FOR_Codigo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JURIDICA>()
                .HasMany(e => e.TRANSFERENCIA_INSUMOS)
                .WithRequired(e => e.JURIDICA)
                .HasForeignKey(e => e.FOR_CodigoInsumo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LINHA_PRODUTO>()
                .Property(e => e.LIN_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<LINHA_PRODUTO>()
                .Property(e => e.LIN_Pct_Comissao)
                .HasPrecision(5, 2);

            modelBuilder.Entity<LOTE>()
                .Property(e => e.LOT_QtdeEstoque)
                .HasPrecision(10, 3);

            modelBuilder.Entity<MEDICOS>()
                .Property(e => e.MED_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<MEDICOS>()
                .Property(e => e.MED_Numero_Registro)
                .IsUnicode(false);

            modelBuilder.Entity<MEDICOS>()
                .Property(e => e.CAL_Sigla)
                .IsUnicode(false);

            modelBuilder.Entity<MEDICOS>()
                .Property(e => e.EST_Sigla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MEDICOS>()
                .HasMany(e => e.SAIDA_INSUMOS)
                .WithRequired(e => e.MEDICOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MEDICOS>()
                .HasMany(e => e.SAIDA_PRODUTOS)
                .WithRequired(e => e.MEDICOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_CONTINGENCIA>()
                .Property(e => e.CON_Xml)
                .IsUnicode(false);

            modelBuilder.Entity<NFCe_INFNOTAFISCAL>()
                .Property(e => e.NFe_ChaveAcesso)
                .IsUnicode(false);

            modelBuilder.Entity<NFCe_INFNOTAFISCAL>()
                .Property(e => e.NFCE_xmlEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<NFCe_INFNOTAFISCAL>()
                .Property(e => e.NFCE_xmlRecebido)
                .IsUnicode(false);

            modelBuilder.Entity<NFCe_INFNOTAFISCAL>()
                .Property(e => e.NFCE_Mensagem)
                .IsUnicode(false);

            modelBuilder.Entity<NFCe_INFNOTAFISCAL>()
                .Property(e => e.NFCe_Protocolo)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_CFOP>()
                .Property(e => e.CFOP_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_CFOP>()
                .Property(e => e.CFOP_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_CFOP>()
                .HasOptional(e => e.NFe_CFOP_CORRESPONDENCIA)
                .WithRequired(e => e.NFe_CFOP);

            modelBuilder.Entity<NFe_CFOP_CORRESPONDENCIA>()
                .Property(e => e.CFOP_NF_Fornecedor)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_CFOP_CORRESPONDENCIA>()
                .Property(e => e.CFOP_Entrada)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_CFOP_CORRESPONDENCIA>()
                .Property(e => e.CFOP_Saida)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_DUPLICATA>()
                .Property(e => e.NFe_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_DUPLICATA>()
                .Property(e => e.DUP_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_DUPLICATA>()
                .Property(e => e.DUP_ValorDuplicata)
                .HasPrecision(15, 2);

            modelBuilder.Entity<NFe_FATURA>()
                .Property(e => e.NFe_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_FATURA>()
                .Property(e => e.FAT_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_FATURA>()
                .Property(e => e.FAT_ValorOrigem)
                .HasPrecision(15, 2);

            modelBuilder.Entity<NFe_FATURA>()
                .Property(e => e.FAT_ValorDesconto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<NFe_FATURA>()
                .Property(e => e.FAT_ValorLiquido)
                .HasPrecision(15, 2);

            modelBuilder.Entity<NFe_INFNOTAFISCAL>()
                .Property(e => e.NFE_xmlEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_INFNOTAFISCAL>()
                .Property(e => e.NFE_xmlRecebido)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_INFNOTAFISCAL>()
                .Property(e => e.NFE_SituacaoEnvio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFe_INFNOTAFISCAL>()
                .Property(e => e.NFe_Valor)
                .HasPrecision(15, 2);

            modelBuilder.Entity<NFe_INFNOTAFISCAL>()
                .Property(e => e.NFe_ChaveAcesso)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_ST_COFINS>()
                .Property(e => e.STCOF_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_ST_COFINS>()
                .Property(e => e.STCOF_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_ST_ICMS>()
                .Property(e => e.STICMS_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_ST_ICMS>()
                .Property(e => e.STICMS_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_ST_ICMS_CORRESPONDENCIA>()
                .Property(e => e.STICMS_NF_Fornecedor)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_ST_ICMS_CORRESPONDENCIA>()
                .Property(e => e.STICMS_Saida)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_ST_ICMS_CORRESPONDENCIA>()
                .HasOptional(e => e.NFe_ST_ICMS_CORRESPONDENCIA1)
                .WithRequired(e => e.NFe_ST_ICMS_CORRESPONDENCIA2);

            modelBuilder.Entity<NFe_ST_IPI>()
                .Property(e => e.STIPI_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_ST_IPI>()
                .Property(e => e.STIPI_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_ST_PIS>()
                .Property(e => e.STPIS_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_ST_PIS>()
                .Property(e => e.STPIS_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_TRANSPORTE>()
                .Property(e => e.NFe_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_TRANSPORTE>()
                .Property(e => e.NTRA_ModalidadeFrete)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFe_TRANSPORTE>()
                .Property(e => e.NTRA_PlacaVeiculo)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_TRANSPORTE>()
                .Property(e => e.NTRA_UF_Placa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFe_TRANSPORTE>()
                .Property(e => e.NTRA_CodigoANTT)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_TRANSPORTE>()
                .Property(e => e.NTRA_Quantidade)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_TRANSPORTE>()
                .Property(e => e.NTRA_Marca)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_TRANSPORTE>()
                .Property(e => e.NTRA_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_TRANSPORTE>()
                .Property(e => e.NTRA_PesoBruto)
                .HasPrecision(10, 3);

            modelBuilder.Entity<NFe_TRANSPORTE>()
                .Property(e => e.NTRA_PesoLiquido)
                .HasPrecision(10, 3);

            modelBuilder.Entity<ORCAMENTO>()
                .Property(e => e.ORC_Valor)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ORCAMENTO>()
                .Property(e => e.ORC_Observacoes)
                .IsUnicode(false);

            modelBuilder.Entity<ORDEM_SERVICO_PRODUTOS_ORDEM>()
                .Property(e => e.IPOS_Ordem)
                .IsUnicode(false);

            modelBuilder.Entity<ORGAO_EXPEDIDOR>()
                .Property(e => e.OEX_Sigla)
                .IsUnicode(false);

            modelBuilder.Entity<ORGAO_EXPEDIDOR>()
                .Property(e => e.OEX_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<ORGAO_EXPEDIDOR>()
                .HasMany(e => e.DOCUMENTO_CLIENTES)
                .WithRequired(e => e.ORGAO_EXPEDIDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAF_DETALHE_REDUCAO_Z>()
                .Property(e => e.DTREDZ_NumeroUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_DETALHE_REDUCAO_Z>()
                .Property(e => e.DTREDZ_CRZ)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_DETALHE_REDUCAO_Z>()
                .Property(e => e.DTREDZ_TotalizadorParcial)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_DETALHE_REDUCAO_Z>()
                .Property(e => e.DTREDZ_ValorAcumulado)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_RELACAO_REDUCAO_Z>()
                .Property(e => e.REDZ_NumeroUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_RELACAO_REDUCAO_Z>()
                .Property(e => e.REDZ_CRZ)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_RELACAO_REDUCAO_Z>()
                .Property(e => e.REDZ_COO)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_RELACAO_REDUCAO_Z>()
                .Property(e => e.REDZ_CRO)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_RELACAO_REDUCAO_Z>()
                .Property(e => e.REDZ_DataMovimento)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_RELACAO_REDUCAO_Z>()
                .Property(e => e.REDZ_DataEmissao)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_RELACAO_REDUCAO_Z>()
                .Property(e => e.REDZ_HoraEmissao)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_RELACAO_REDUCAO_Z>()
                .Property(e => e.REDZ_VendaBruta)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_RELACAO_REDUCAO_Z>()
                .Property(e => e.REDZ_ParametroECF)
                .IsUnicode(false);

            modelBuilder.Entity<PAF_RELACAO_REDUCAO_Z>()
                .Property(e => e.REDZ_ValorTotalizadorGeral)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETROS_TEF>()
                .Property(e => e.TEF_ContraSenha)
                .IsUnicode(false);

            modelBuilder.Entity<PERDA_INSUMOS>()
                .Property(e => e.PIN_NumeroLote)
                .IsUnicode(false);

            modelBuilder.Entity<PERDA_INSUMOS>()
                .Property(e => e.PIN_Quantidade)
                .HasPrecision(5, 1);

            modelBuilder.Entity<PERDA_PRODUTOS>()
                .Property(e => e.PPR_NumeroLote)
                .IsUnicode(false);

            modelBuilder.Entity<PERDA_PRODUTOS>()
                .Property(e => e.PRO_RegistroMsInventario)
                .IsUnicode(false);

            modelBuilder.Entity<PERFIL>()
                .Property(e => e.PER_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<PERFIL>()
                .Property(e => e.PER_Liberado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PERIODICIDADE>()
                .Property(e => e.PDE_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Cep)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Uf)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Email)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Celular)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_TipoPessoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_TipoCadastro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Bloqueado)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_LimiteCredito)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Pct_Desconto)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_Pct_Juros)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_TipoCobranca)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_DiaCobranca)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.PES_NumeroEndereco)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.CONSIGNADO)
                .WithRequired(e => e.PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.COPS_MOVIMENTO)
                .WithRequired(e => e.PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.ENDERECO_ENTREGA)
                .WithRequired(e => e.PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.ENTREGA_EFETUADA)
                .WithRequired(e => e.PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasOptional(e => e.FISICA)
                .WithRequired(e => e.PESSOA);

            modelBuilder.Entity<PESSOA>()
                .HasOptional(e => e.JURIDICA)
                .WithRequired(e => e.PESSOA);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.ORCAMENTO)
                .WithRequired(e => e.PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.SER_SERVICO)
                .WithRequired(e => e.PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.USUARIO)
                .WithRequired(e => e.PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.VENDA)
                .WithRequired(e => e.PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA_CLASSIFICACAO>()
                .Property(e => e.PCLAS_Desconto)
                .HasPrecision(15, 3);

            modelBuilder.Entity<PET_CONSULTA>()
                .Property(e => e.CON_Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<PET_CONSULTA_ITEM_nao_usar>()
                .Property(e => e.PRO_Quantidade)
                .HasPrecision(10, 3);

            modelBuilder.Entity<PET_CONSULTA_ITEM_nao_usar>()
                .Property(e => e.PRO_Venda)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PET_CONSULTA_SERVICO_nao_usar>()
                .Property(e => e.SER_Valor)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PET_CONSULTA_SERVICO_nao_usar>()
                .Property(e => e.SER_Quantidade)
                .HasPrecision(10, 3);

            modelBuilder.Entity<PET_ESPECIE>()
                .Property(e => e.ESP_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<PET_ESPECIE>()
                .HasMany(e => e.PET_RACA)
                .WithRequired(e => e.PET_ESPECIE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PET_FICHA_RECEITUARIO>()
                .Property(e => e.REC_Anamnese)
                .IsUnicode(false);

            modelBuilder.Entity<PET_FICHA_RECEITUARIO>()
                .Property(e => e.REC_Receita)
                .IsUnicode(false);

            modelBuilder.Entity<PET_FICHA_RECEITUARIO>()
                .Property(e => e.REC_Peso)
                .IsUnicode(false);

            modelBuilder.Entity<PET_FICHA_RECEITUARIO>()
                .Property(e => e.REC_Diagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<PET_PACIENTE>()
                .Property(e => e.PAC_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<PET_PACIENTE>()
                .Property(e => e.PAC_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<PET_PACIENTE>()
                .Property(e => e.PAC_Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PET_PACIENTE>()
                .Property(e => e.PAC_Idade)
                .IsUnicode(false);

            modelBuilder.Entity<PET_PACIENTE>()
                .Property(e => e.PAC_Foto)
                .IsUnicode(false);

            modelBuilder.Entity<PET_PACIENTE>()
                .HasMany(e => e.PET_CONSULTA)
                .WithRequired(e => e.PET_PACIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PET_PELAGEM>()
                .Property(e => e.PEL_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<PET_RACA>()
                .Property(e => e.RAC_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<PET_SERVICO_NAO_USARMAIS>()
                .Property(e => e.SER_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<PET_SERVICO_NAO_USARMAIS>()
                .Property(e => e.SER_Valor)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PET_SERVICO_NAO_USARMAIS>()
                .Property(e => e.SER_Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<PET_TIPO_RETORNO_VACINA>()
                .Property(e => e.TRV_Retorno)
                .IsUnicode(false);

            modelBuilder.Entity<PET_TIPO_RETORNO_VACINA>()
                .Property(e => e.TRV_Dias)
                .IsUnicode(false);

            modelBuilder.Entity<PET_VACINA>()
                .Property(e => e.VAC_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<PET_VACINA>()
                .Property(e => e.VAC_Doses)
                .IsUnicode(false);

            modelBuilder.Entity<PET_VACINA>()
                .Property(e => e.VAC_ProximaVacina)
                .IsUnicode(false);

            modelBuilder.Entity<PLANO_CONTAS>()
                .Property(e => e.PCT_CodigoConta)
                .IsUnicode(false);

            modelBuilder.Entity<PLANO_CONTAS>()
                .Property(e => e.PCT_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<PLANO_CONTAS>()
                .Property(e => e.PCT_Conta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PLANO_CONTAS>()
                .Property(e => e.PCT_SensibilizaCaixa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PLANO_CONTAS>()
                .Property(e => e.PCT_ContaSistema)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Cod_Fai)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Cod_Barra)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Apresentacao)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Vlr_CustoFabrica)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Vlr_CustoReal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Vlr_Venda)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Vlr_CustoMedio)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Vrl_CustoMedioReal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Pct_ComissaoVista)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Pct_DescAVista)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Pct_DescAPrazo)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Pct_ComissaoPrazo)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Pct_Lucro)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Estoque_Minimo)
                .HasPrecision(10, 3);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Estoque_Atual)
                .HasPrecision(10, 3);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Balcao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Psicotropico)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_UsoContinuo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_DescAVistaAtivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_DescAPrazoAtivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Imagem)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_CodigoRegistroMS)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_CodigoNCM)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_IpiEntrada)
                .HasPrecision(10, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Aplicacao)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.CFOP_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_InformacoesAdicionais)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_CodigoExcecao_NCM)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.STICMS_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Origem_ICMS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.STIPI_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.STPIS_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.STCOF_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_TipoItem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_AliqICMS)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Vlr_Venda_Promocao)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Vlr_Venda_Anterior)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PROAliqICMS)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_Estoque_Reducao)
                .HasPrecision(10, 3);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRO_RedBaseCalcICMS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.ENTRADA_PRODUTOS)
                .WithRequired(e => e.PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.LOTE)
                .WithRequired(e => e.PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.PERDA_PRODUTOS)
                .WithRequired(e => e.PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.PRODUTO_INVENTARIO)
                .WithRequired(e => e.PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.SAIDA_PRODUTOS)
                .WithRequired(e => e.PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.SUBSTANCIA_PRODUTO)
                .WithRequired(e => e.PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.TRANSFERENCIA_PRODUTOS)
                .WithRequired(e => e.PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.VENDA_LOTE)
                .WithRequired(e => e.PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO_INVENTARIO>()
                .Property(e => e.PRO_Lote)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_INVENTARIO>()
                .Property(e => e.PRO_RegistroMSInventario)
                .IsUnicode(false);

            modelBuilder.Entity<PSICO_CLIENTE>()
                .Property(e => e.PCLI_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<PSICO_CLIENTE>()
                .HasMany(e => e.DOCUMENTO_CLIENTES)
                .WithRequired(e => e.PSICO_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PSICO_CLIENTE>()
                .HasMany(e => e.SAIDA_PRODUTOS)
                .WithRequired(e => e.PSICO_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PSICO_CONFIGURACOES>()
                .Property(e => e.PSI_HashIdentificacao)
                .IsUnicode(false);

            modelBuilder.Entity<PSICO_CONFIGURACOES>()
                .Property(e => e.PSI_CaminhoArquivo)
                .IsUnicode(false);

            modelBuilder.Entity<PSICO_CONFIGURACOES>()
                .Property(e => e.PSI_ValidadoAnvisa)
                .IsUnicode(false);

            modelBuilder.Entity<PSICO_CONFIGURACOES>()
                .Property(e => e.PSI_MsgRetorno)
                .IsUnicode(false);

            modelBuilder.Entity<REGISTRO_ECF>()
                .Property(e => e.REG_Serial)
                .IsUnicode(false);

            modelBuilder.Entity<REGISTRO_ECF>()
                .Property(e => e.IMP_MFAdicional)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<REGISTRO_ECF>()
                .Property(e => e.IMP_TipoECF)
                .IsFixedLength();

            modelBuilder.Entity<REGISTRO_ECF>()
                .Property(e => e.IMP_ModeloECF)
                .IsFixedLength();

            modelBuilder.Entity<REGISTRO_ECF>()
                .Property(e => e.IMP_VersaoSB)
                .IsFixedLength();

            modelBuilder.Entity<RESPONSAVEL_TECNICO>()
                .Property(e => e.RTE_Email)
                .IsUnicode(false);

            modelBuilder.Entity<RESPONSAVEL_TECNICO>()
                .Property(e => e.RTE_Senha)
                .IsUnicode(false);

            modelBuilder.Entity<RESPONSAVEL_TECNICO>()
                .Property(e => e.RTE_CRF)
                .IsUnicode(false);

            modelBuilder.Entity<RESPONSAVEL_TECNICO>()
                .Property(e => e.RTE_CRFEstado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RESPONSAVEL_TECNICO>()
                .Property(e => e.RTE_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<SAIDA_INSUMOS>()
                .Property(e => e.SIN_NumeroReceita)
                .IsUnicode(false);

            modelBuilder.Entity<SAIDA_INSUMOS>()
                .Property(e => e.SIN_NumeroLote)
                .IsUnicode(false);

            modelBuilder.Entity<SAIDA_INSUMOS>()
                .Property(e => e.SIN_Qtde_UnidadeInsumo)
                .HasPrecision(5, 1);

            modelBuilder.Entity<SAIDA_INSUMOS>()
                .Property(e => e.SIN_Qtde_UnidadeFarmacotecnica)
                .HasPrecision(5, 1);

            modelBuilder.Entity<SAIDA_INSUMOS>()
                .HasOptional(e => e.SAIDA_INSUMOS1)
                .WithRequired(e => e.SAIDA_INSUMOS2);

            modelBuilder.Entity<SAIDA_PRODUTOS>()
                .Property(e => e.SPR_NumeroReceita)
                .IsUnicode(false);

            modelBuilder.Entity<SAIDA_PRODUTOS>()
                .Property(e => e.SPR_NumeroLote)
                .IsUnicode(false);

            modelBuilder.Entity<SAIDA_PRODUTOS>()
                .Property(e => e.PRO_RegistroMsInventario)
                .IsUnicode(false);

            modelBuilder.Entity<SER_CARRO>()
                .Property(e => e.CAR_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<SER_CARRO>()
                .HasMany(e => e.SER_VEICULO)
                .WithRequired(e => e.SER_CARRO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_COMPRA_ITEM>()
                .Property(e => e.COI_Quantidade)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SER_COMPRA_ITEM>()
                .Property(e => e.COI_ValorCustoCompra)
                .HasPrecision(15, 3);

            modelBuilder.Entity<SER_COR>()
                .Property(e => e.COR_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<SER_COR>()
                .HasMany(e => e.SER_VEICULO)
                .WithRequired(e => e.SER_COR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_EQUIPAMENTO>()
                .Property(e => e.EQUI_Serial)
                .IsUnicode(false);

            modelBuilder.Entity<SER_EQUIPAMENTO>()
                .Property(e => e.EQUI_ValorImobilizado)
                .HasPrecision(15, 2);

            modelBuilder.Entity<SER_EQUIPAMENTO_MODELO>()
                .Property(e => e.EQUIMOD_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<SER_EQUIPAMENTO_NOME>()
                .Property(e => e.EQUINOM_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<SER_FUNCIONARIO>()
                .Property(e => e.FUN_Nome)
                .IsUnicode(false);

            modelBuilder.Entity<SER_MONTADORA>()
                .Property(e => e.MON_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<SER_MONTADORA>()
                .HasMany(e => e.SER_CARRO)
                .WithRequired(e => e.SER_MONTADORA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_PARTE>()
                .Property(e => e.PAR_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<SER_PARTE>()
                .HasMany(e => e.SER_SERVICO_PARTE)
                .WithRequired(e => e.SER_PARTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_SERVICO>()
                .Property(e => e.SER_NumeroControle)
                .IsUnicode(false);

            modelBuilder.Entity<SER_SERVICO>()
                .Property(e => e.SER_DefeitoReclamado)
                .IsUnicode(false);

            modelBuilder.Entity<SER_SERVICO>()
                .Property(e => e.SER_Solicitante)
                .IsUnicode(false);

            modelBuilder.Entity<SER_SERVICO>()
                .Property(e => e.SER_OSCliente)
                .IsUnicode(false);

            modelBuilder.Entity<SER_SERVICO>()
                .Property(e => e.SER_SolucaoDefeito)
                .IsUnicode(false);

            modelBuilder.Entity<SER_SERVICO>()
                .Property(e => e.SER_KmHrs)
                .IsUnicode(false);

            modelBuilder.Entity<SER_SERVICO>()
                .Property(e => e.SER_NotaFiscalFatura)
                .IsUnicode(false);

            modelBuilder.Entity<SER_SERVICO>()
                .Property(e => e.SER_NotaFiscalServico)
                .IsUnicode(false);

            modelBuilder.Entity<SER_SERVICO>()
                .Property(e => e.SER_NumeroPedidoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<SER_SERVICO>()
                .Property(e => e.SER_Observacao)
                .IsUnicode(false);

            modelBuilder.Entity<SER_SERVICO>()
                .HasMany(e => e.SER_SERVICO_PARTE)
                .WithRequired(e => e.SER_SERVICO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SER_SERVICO_PARTE>()
                .Property(e => e.SERPAR_DefeitoReclamado)
                .IsUnicode(false);

            modelBuilder.Entity<SER_SERVICO_PARTE>()
                .Property(e => e.SERPAR_SolucaoDefeito)
                .IsUnicode(false);

            modelBuilder.Entity<SER_STATUS>()
                .Property(e => e.STA_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<SER_TIPO_SERVICO>()
                .Property(e => e.TSE_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<SER_VEICULO>()
                .Property(e => e.VEI_Ano)
                .IsUnicode(false);

            modelBuilder.Entity<SER_VEICULO>()
                .Property(e => e.VEI_Placa)
                .IsUnicode(false);

            modelBuilder.Entity<SER_VEICULO>()
                .Property(e => e.VEI_Frota)
                .IsUnicode(false);

            modelBuilder.Entity<SER_VEICULO>()
                .Property(e => e.VEI_Serie)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSTANCIA>()
                .Property(e => e.SUB_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSTANCIA>()
                .Property(e => e.GRP_Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSTANCIA>()
                .Property(e => e.SUB_DCB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUBSTANCIA>()
                .Property(e => e.SUB_CAS)
                .IsUnicode(false);

            modelBuilder.Entity<SUBSTANCIA>()
                .Property(e => e.NUM_Concent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUBSTANCIA>()
                .HasMany(e => e.ENTRADA_INSUMOS)
                .WithRequired(e => e.SUBSTANCIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUBSTANCIA>()
                .HasMany(e => e.PERDA_INSUMOS)
                .WithRequired(e => e.SUBSTANCIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUBSTANCIA>()
                .HasMany(e => e.SAIDA_INSUMOS)
                .WithRequired(e => e.SUBSTANCIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUBSTANCIA>()
                .HasMany(e => e.TRANSFERENCIA_INSUMOS)
                .WithRequired(e => e.SUBSTANCIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_DOCUMENTOS>()
                .Property(e => e.TDO_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_DOCUMENTOS>()
                .HasMany(e => e.DOCUMENTO_CLIENTES)
                .WithRequired(e => e.TIPO_DOCUMENTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_DOCUMENTOS>()
                .HasMany(e => e.SAIDA_INSUMOS)
                .WithRequired(e => e.TIPO_DOCUMENTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_DOCUMENTOS>()
                .HasMany(e => e.SAIDA_PRODUTOS)
                .WithRequired(e => e.TIPO_DOCUMENTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_MOTIVO_PERDA>()
                .Property(e => e.TMP_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_MOTIVO_PERDA>()
                .HasMany(e => e.PERDA_INSUMOS)
                .WithRequired(e => e.TIPO_MOTIVO_PERDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_MOTIVO_PERDA>()
                .HasMany(e => e.PERDA_PRODUTOS)
                .WithRequired(e => e.TIPO_MOTIVO_PERDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_NOTAFISCAL>()
                .Property(e => e.TNF_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_NOTAFISCAL>()
                .HasMany(e => e.ENTRADA_INSUMOS)
                .WithRequired(e => e.TIPO_NOTAFISCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_NOTAFISCAL>()
                .HasMany(e => e.ENTRADA_PRODUTOS)
                .WithRequired(e => e.TIPO_NOTAFISCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_NOTAFISCAL>()
                .HasMany(e => e.TRANSFERENCIA_INSUMOS)
                .WithRequired(e => e.TIPO_NOTAFISCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_NOTAFISCAL>()
                .HasMany(e => e.TRANSFERENCIA_PRODUTOS)
                .WithRequired(e => e.TIPO_NOTAFISCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_PRODUTO>()
                .Property(e => e.TIP_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_RECEITUARIO>()
                .Property(e => e.TIO_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_RECEITUARIO>()
                .HasMany(e => e.SAIDA_INSUMOS)
                .WithRequired(e => e.TIPO_RECEITUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_RECEITUARIO>()
                .HasMany(e => e.SAIDA_PRODUTOS)
                .WithRequired(e => e.TIPO_RECEITUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_UNIDADE_FARMACOTECNICA>()
                .Property(e => e.TUF_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_UNIDADE_FARMACOTECNICA>()
                .HasMany(e => e.SAIDA_INSUMOS)
                .WithRequired(e => e.TIPO_UNIDADE_FARMACOTECNICA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_UNIDADE_INSUMO>()
                .Property(e => e.TUI_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_UNIDADE_INSUMO>()
                .HasMany(e => e.ENTRADA_INSUMOS)
                .WithRequired(e => e.TIPO_UNIDADE_INSUMO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_UNIDADE_INSUMO>()
                .HasMany(e => e.PERDA_INSUMOS)
                .WithRequired(e => e.TIPO_UNIDADE_INSUMO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_UNIDADE_INSUMO>()
                .HasMany(e => e.SAIDA_INSUMOS)
                .WithRequired(e => e.TIPO_UNIDADE_INSUMO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_UNIDADE_INSUMO>()
                .HasMany(e => e.TRANSFERENCIA_INSUMOS)
                .WithRequired(e => e.TIPO_UNIDADE_INSUMO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_USO_MEDICAMENTO>()
                .Property(e => e.TUM_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_USO_MEDICAMENTO>()
                .HasMany(e => e.SAIDA_INSUMOS)
                .WithRequired(e => e.TIPO_USO_MEDICAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_USO_MEDICAMENTO>()
                .HasMany(e => e.SAIDA_PRODUTOS)
                .WithRequired(e => e.TIPO_USO_MEDICAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_VENDA>()
                .Property(e => e.TPV_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERENCIA_INSUMOS>()
                .Property(e => e.TIN_NumeroNF)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERENCIA_INSUMOS>()
                .Property(e => e.TIN_Quantidade)
                .HasPrecision(5, 1);

            modelBuilder.Entity<TRANSFERENCIA_INSUMOS>()
                .Property(e => e.TIN_NumeroLote)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERENCIA_PRODUTOS>()
                .Property(e => e.TPR_NumeroNF)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSFERENCIA_PRODUTOS>()
                .Property(e => e.TPR_NumeroLote)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_RazaoSocial)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_Fantasia)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_Cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_InscricaoEstadual)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_Numero)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_Cidade)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_Bairro)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_UF)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_CEP)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_Fone1)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_Fone2)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORAS>()
                .Property(e => e.TRA_Contato)
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUTACAO>()
                .Property(e => e.TRB_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUTACAO>()
                .Property(e => e.TRB_AliquotaSped)
                .HasPrecision(6, 2);

            modelBuilder.Entity<TRIBUTACAO>()
                .Property(e => e.trb_pct_aliquota)
                .IsUnicode(false);

            modelBuilder.Entity<UNIDADE_MEDIDA>()
                .Property(e => e.UNI_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<UNIDADE_MEDIDA>()
                .Property(e => e.UNI_Sigla)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.USR_Login)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.USR_Senha)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.USR_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.FPO_LoginVendedorCPF)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.FPO_SenhaVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.USR_NivelAcesso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .HasMany(e => e.CHEQUE)
                .WithRequired(e => e.USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIO>()
                .HasMany(e => e.COPS_MOVIMENTO)
                .WithRequired(e => e.USUARIO)
                .HasForeignKey(e => e.USU_Codigo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIO>()
                .HasMany(e => e.DEVOLUCAO)
                .WithOptional(e => e.USUARIO)
                .HasForeignKey(e => e.USU_Codigo_movimento);

            modelBuilder.Entity<USUARIO>()
                .HasMany(e => e.ENTRADA)
                .WithOptional(e => e.USUARIO)
                .HasForeignKey(e => e.USU_Codigo);

            modelBuilder.Entity<USUARIO>()
                .HasMany(e => e.VENDA)
                .WithOptional(e => e.USUARIO)
                .HasForeignKey(e => e.USR_UsuarioSistema);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.VDA_Historico)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.VDA_Valor)
                .HasPrecision(15, 2);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.VDA_DescontoTotal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.VDA_ValorDevolvido)
                .HasPrecision(15, 2);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.VDA_ValorDescontoDevolucao)
                .HasPrecision(15, 2);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.VDA_PctDescontoTotal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.VDA_NomeCliente)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.VDA_ControlaEntrega)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.VDA_ValorHaver)
                .HasPrecision(15, 4);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.VDA_SituacaoEnvio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.VDA_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA>()
                .HasMany(e => e.CHEQUE)
                .WithRequired(e => e.VENDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA>()
                .HasMany(e => e.CONTAS_RECEBER)
                .WithRequired(e => e.VENDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA>()
                .HasMany(e => e.ITENS_CONSIGNADO)
                .WithRequired(e => e.VENDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA>()
                .HasMany(e => e.ITENS_VENDA)
                .WithRequired(e => e.VENDA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA_LOTE>()
                .Property(e => e.LOT_QtdeEstoque)
                .HasPrecision(10, 3);

            modelBuilder.Entity<VENDA_PAGAMENTO>()
                .Property(e => e.VPG_Valor)
                .HasPrecision(15, 2);

            modelBuilder.Entity<NFe_IBGE_CIDADE>()
                .Property(e => e.CID_NomeCidade)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_IBGE_CIDADE>()
                .Property(e => e.CID_SiglaEstado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFe_IBPTAX_Tabela>()
                .Property(e => e.IBPT_CodigoNCM)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_IBPTAX_Tabela>()
                .Property(e => e.IBPT_CodigoExcecaoNCM)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_IBPTAX_Tabela>()
                .Property(e => e.IBPT_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_IBPTAX_Tabela>()
                .Property(e => e.IBPT_AliquotaNacional)
                .HasPrecision(5, 2);

            modelBuilder.Entity<NFe_IBPTAX_Tabela>()
                .Property(e => e.IBPT_AliquotaImportacao)
                .HasPrecision(5, 2);

            modelBuilder.Entity<NFe_IBPTAX_Tabela>()
                .Property(e => e.IBPT_VersaoArquivoIBPTAX)
                .IsUnicode(false);

            modelBuilder.Entity<NFe_IBPTAX_Tabela>()
                .Property(e => e.IBPT_CEST)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETROS_FPOPULAR>()
                .Property(e => e.FPO_SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETROS_FPOPULAR>()
                .Property(e => e.FPO_CODIGO_SOLICITACAO)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETROS_FPOPULAR>()
                .Property(e => e.FPO_CODIGO_AUTORIZACAOFP)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETROS_FPOPULAR>()
                .Property(e => e.FPO_CODIGO_CUPOM)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETROS_FPOPULAR>()
                .Property(e => e.FPO_UsuarioVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<PARAMETROS_FPOPULAR>()
                .Property(e => e.FPO_SenhaVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO_ACESSO>()
                .Property(e => e.USA_Grau_1)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO_ACESSO>()
                .Property(e => e.USA_Grau_2)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO_ACESSO>()
                .Property(e => e.USA_Grau_3)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_CPF_CNPJ>()
                .Property(e => e.VDA_CpfCnpj)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_RedBaseCalcICMS)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_MsgAdicionais)
                .IsFixedLength();

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_CFOP)
                .IsFixedLength();

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_STCOFINS)
                .IsFixedLength();

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_STPIS)
                .IsFixedLength();

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_STIPI)
                .IsFixedLength();

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_Origem_ICMS)
                .IsFixedLength();

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_STICMS)
                .IsFixedLength();

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_CodExcecao_NCM)
                .IsFixedLength();

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_CodigoNCM)
                .IsFixedLength();

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_Historico)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.PRO_Apresentacao)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.PRO_Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_PctDescontoTotal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_PctDescontoProduto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_ValorDescontoDevolvido)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_ValorDevolvido)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_QuantidadeEstorno)
                .HasPrecision(10, 3);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_PctComissao)
                .HasPrecision(15, 0);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_ComissaoPaga)
                .HasPrecision(15, 0);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_Lote)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_ValorVendaFinal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_ValorDescontoItemDevolucao)
                .HasPrecision(15, 3);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_ValorDescontoProduto)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_ValorVendaUnitario)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_CustoFabrica)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_CustoReal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.IVD_Quantidade)
                .HasPrecision(10, 3);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.VDA_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.VDA_SituacaoEnvio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.VDA_ValorHaver)
                .HasPrecision(15, 4);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.VDA_ControlaEntrega)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.VDA_NomeCliente)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.VDA_PctDescontoTotal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.VDA_ValorDescontoDevolucao)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.VDA_ValorDevolvido)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.VDA_DescontoTotal)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.VDA_Valor)
                .HasPrecision(15, 2);

            modelBuilder.Entity<ConsultaVendas>()
                .Property(e => e.VDA_Historico)
                .IsUnicode(false);
        }
    }
}
