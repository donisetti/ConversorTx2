using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using ConversorTX2.Contexto;

namespace ConversorTX2
{
    class Program
    {
        static void Main(string[] args)
        {
            string vazio = "";

            // Conecta com Base de Dados
            using (DBContexto db = new DBContexto())
            {

                // Cria e Gravação do arquivo Formato TX2
            
               
                //Console.WriteLine("[sourcecode]");

              
                foreach (var nota in db.VENDA.ToList().Take(10))
                {
                    string arq = $"C:\\Projetos\\Nutryervas\\TX2\\{nota.VDA_Codigo.ToString("0000")}.txt";

                    var fs = new FileStream(arq, FileMode.Create, FileAccess.Write);
                    var arquivo = new StreamWriter(fs, Encoding.UTF8);

                    var tx2 = new StringBuilder();

                    tx2.AppendLine($"[sourcecode]");

                    tx2.AppendLine($"NumLote={vazio}");
                    tx2.AppendLine($"Formato=tx2 ");
                    tx2.AppendLine($"INCLUIR ");
                    tx2.AppendLine($"Id_A03=0 ");
                    tx2.AppendLine($"versao_A02=2.00 ");
                    tx2.AppendLine($"cUF_B02={vazio} ");
                    tx2.AppendLine($"cNF_B03={vazio} ");
                    tx2.AppendLine($"nNF_B08={vazio} ");
                    tx2.AppendLine($"natOp_B04={vazio} ");
                    tx2.AppendLine($"indPag_B05={vazio} ");
                    tx2.AppendLine($"mod_B06=55 ");
                    tx2.AppendLine($"serie_B07={vazio} ");
                    tx2.AppendLine($"DEMI_B09=2012-06-12 ");
                    tx2.AppendLine($"DSAIENT_B10=2012-06-12 ");
                    tx2.AppendLine($"HSAIENT_B10A=10:02:49 ");
                    tx2.AppendLine($"tpNF_B11={vazio} ");
                    tx2.AppendLine($"cMunFG_B12={vazio}");
                    tx2.AppendLine($"tpImp_B21={vazio} ");
                    tx2.AppendLine($"tpEmis_B22={vazio} ");
                    tx2.AppendLine($"cDV_B23={vazio} ");
                    tx2.AppendLine($"tpAmb_B24={vazio} ");
                    tx2.AppendLine($"finNFe_B25={vazio} ");
                    tx2.AppendLine($"procEmi_B26={vazio} ");
                    tx2.AppendLine($"verProc_B27={vazio} ");

                    tx2.AppendLine($"{vazio}");

                    tx2.AppendLine($"CRT_C21={vazio} ");
                    tx2.AppendLine($"CNPJ_C02={vazio} ");
                    tx2.AppendLine($"xNome_C03={vazio} ");
                    tx2.AppendLine($"xFant_C04={vazio} ");
                    tx2.AppendLine($"xLgr_C06={vazio} ");
                    tx2.AppendLine($"nro_C07={vazio} ");
                    tx2.AppendLine($"xBairro_C09={vazio} ");
                    tx2.AppendLine($"cMun_C10={vazio} ");
                    tx2.AppendLine($"xMun_C11={vazio} ");
                    tx2.AppendLine($"UF_C12={vazio} ");
                    tx2.AppendLine($"CEP_C13={vazio} ");
                    tx2.AppendLine($"cPais_C14={vazio} ");
                    tx2.AppendLine($"xPais_C15={vazio} ");
                    tx2.AppendLine($"fone_C16={vazio} ");
                    tx2.AppendLine($"IE_C17={vazio} ");

                    tx2.AppendLine($"{vazio}");

                    tx2.AppendLine($"CNPJ_E02={vazio} ");
                    tx2.AppendLine($"xNome_E04={vazio} ");
                    tx2.AppendLine($"xLgr_E06={vazio} ");
                    tx2.AppendLine($"nro_E07={vazio} ");
                    tx2.AppendLine($"xBairro_E09={vazio} ");
                    tx2.AppendLine($"cMun_E10={vazio} ");
                    tx2.AppendLine($"xMun_E11={vazio} ");
                    tx2.AppendLine($"UF_E12={vazio} ");
                    tx2.AppendLine($"CEP_E13={vazio} ");
                    tx2.AppendLine($"cPais_E14={vazio} ");
                    tx2.AppendLine($"xPais_E15={vazio} ");
                    tx2.AppendLine($"fone_E16={vazio} ");
                    tx2.AppendLine($"IE_E17={vazio} ");
                    tx2.AppendLine($"email_e19={vazio} ");

                    tx2.AppendLine($"{vazio}");




                    //tx2.AppendLine($"[sourcecode]");



                    foreach (var produto in nota.ITENS_VENDA)
                    {

                        tx2.AppendLine($"INCLUIRITEM ");
                        tx2.AppendLine($"nItem_H02={vazio} ");
                        tx2.AppendLine($"cProd_I02={vazio} ");
                        tx2.AppendLine($"cEAN_I03={vazio} ");
                        tx2.AppendLine($"xProd_I04={vazio} ");
                        tx2.AppendLine($"NCM_I05={vazio} ");
                        tx2.AppendLine($"CFOP_I08={vazio} ");
                        tx2.AppendLine($"uCom_I09={vazio} ");
                        tx2.AppendLine($"qCom_I10={vazio} ");
                        tx2.AppendLine($"vUnCom_I10a={vazio} ");
                        tx2.AppendLine($"vProd_I11={vazio} ");
                        tx2.AppendLine($"cEANTrib_I12={vazio} ");
                        tx2.AppendLine($"uTrib_I13={vazio} ");
                        tx2.AppendLine($"qTrib_I14={vazio} ");
                        tx2.AppendLine($"vUnTrib_I14a={vazio} ");

                        tx2.AppendLine($"{vazio}");

                        tx2.AppendLine($"indTot_I17b={vazio} ");

                        tx2.AppendLine($"{vazio}");

                        tx2.AppendLine($"orig_N11={vazio} ");
                        tx2.AppendLine($"CST_N12={vazio} ");
                        tx2.AppendLine($"modBC_N13={vazio} ");
                        tx2.AppendLine($"vBC_N15={vazio} ");
                        tx2.AppendLine($"pICMS_N16={vazio} ");
                        tx2.AppendLine($"vICMS_N17={vazio} ");

                        tx2.AppendLine($"{vazio}");

                        tx2.AppendLine($"CST_Q06={vazio} ");
                        tx2.AppendLine($"vBC_Q07={vazio} ");
                        tx2.AppendLine($"pPIS_Q08={vazio} ");
                        tx2.AppendLine($"vPIS_Q09={vazio} ");

                        tx2.AppendLine($"{vazio}");

                        tx2.AppendLine($"CST_S06={vazio} ");
                        tx2.AppendLine($"vBC_S07={vazio} ");
                        tx2.AppendLine($"pCOFINS_S08={vazio} ");
                        tx2.AppendLine($"vCOFINS_S11={vazio} ");

                        tx2.AppendLine($"{vazio}");

                        tx2.AppendLine($"tpArma_l02={vazio} ");
                        tx2.AppendLine($"nSerie_l03={vazio} ");
                        tx2.AppendLine($"nCano_l04={vazio} ");
                        tx2.AppendLine($"descr_l05={vazio} ");

                        tx2.AppendLine($"{vazio}");

                        tx2.AppendLine($"SALVARITEM  ");
                    }


                    tx2.AppendLine($"vBC_W03={vazio} ");
                    tx2.AppendLine($"vICMS_W04={vazio} ");
                    tx2.AppendLine($"vBCST_W05={vazio} ");
                    tx2.AppendLine($"vST_W06=");
                    tx2.AppendLine($"vProd_W07={vazio} ");
                    tx2.AppendLine($"vFrete_W08={vazio} ");
                    tx2.AppendLine($"vSeg_W09={vazio} ");
                    tx2.AppendLine($"vDesc_W10={vazio} ");
                    tx2.AppendLine($"vII_W11={vazio} ");
                    tx2.AppendLine($"vIPI_W12={vazio} ");
                    tx2.AppendLine($"vPIS_W13={vazio} ");
                    tx2.AppendLine($"vCOFINS_W14={vazio} ");
                    tx2.AppendLine($"vOutro_W15={vazio} ");
                    tx2.AppendLine($"vNF_W16={vazio} ");

                    tx2.AppendLine($"{vazio}");

                    tx2.AppendLine($"modFrete_X02={vazio} ");

                    tx2.AppendLine($"{vazio}");

                    tx2.AppendLine($"nFat_Y03={vazio} ");
                    tx2.AppendLine($"vOrig_Y04={vazio} ");
                    tx2.AppendLine($"vDesc_Y05={vazio} ");
                    tx2.AppendLine($"vLiq_Y06={vazio} ");

                    tx2.AppendLine($"{vazio}");

                    tx2.AppendLine($"infAdFisco_Z02={vazio} ");
                    tx2.AppendLine($"infCpl_Z03={vazio} ");

                    tx2.AppendLine($"{vazio}");

                    tx2.AppendLine($"EMAILDESTINATARIO={vazio} ");

                    tx2.AppendLine($"{vazio}");

                    tx2.AppendLine($"SALVAR ");
                    tx2.AppendLine($"[/sourcecode]");
                    

                    // Mostra na tela

                    // Grava os dados no arquivo
                    arquivo.Write(tx2);
                   

                    arquivo.Close();

                    Console.Write(".");
                  
                }

               
            }
            Console.Write(" Operação completa.");
            Console.ReadLine();
        }
    }
}
