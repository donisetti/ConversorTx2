using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ConversorTX2.Contexto;

namespace TransmissaoNFE
{
    public class ServicoHtttp
    {
        public  void TransmitirNFe()
        {
            string usuario = "admin";
            string senha = "123mudar";
            string vazio = "";

           

            // Conecta com Base de Dados
            using (DBContexto db = new DBContexto())
            {
                var dados = db.VENDA.Where(x => x.VDA_Codigo == 7).ToList();


                foreach (var nota in dados)
                {
                    var tx2 = new StringBuilder();

                    tx2.AppendLine($"formato=tx2{vazio}");
                    tx2.AppendLine($"numLote=0");
                    tx2.AppendLine($"grupo=edoc");
                    tx2.AppendLine($"cnpj=08187168000160");
                    tx2.AppendLine($"INCLUIR{vazio}");
                    tx2.AppendLine($"Id_A03=0{vazio}");
                    tx2.AppendLine($"versao_A02=3.10{vazio}");
                    tx2.AppendLine($"cUF_B02=41{vazio}");
                    tx2.AppendLine($"cNF_B03=01{vazio}");
                    tx2.AppendLine($"natOp_B04=VENDA MERC.ADQ.REC.TERC{vazio}");
                    tx2.AppendLine($"indPag_B05=1{vazio}");
                    tx2.AppendLine($"mod_B06=55{vazio}");
                    tx2.AppendLine($"serie_B07=666{vazio}");
                    tx2.AppendLine($"nNF_B08=1400{vazio}");
                    tx2.AppendLine($"dhEmi_B09={DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")}");
                    tx2.AppendLine($"dhSaiEnt_B10={DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz")}");
                    tx2.AppendLine($"tpNF_B11=1{vazio}");
                    tx2.AppendLine($"idDest_B11a=2{vazio}");
                    tx2.AppendLine($"cMunFG_B12=4115200{vazio}");
                    tx2.AppendLine($"tpImp_B21=1{vazio}");
                    tx2.AppendLine($"tpEmis_B22=1{vazio}");
                    tx2.AppendLine($"cDV_B23=0{vazio}");
                    tx2.AppendLine($"tpAmb_B24=2{vazio}");
                    tx2.AppendLine($"finNFe_B25=1{vazio}");
                    tx2.AppendLine($"indFinal_B25a=0{vazio}");
                    tx2.AppendLine($"indPres_B25b=9{vazio}");
                    tx2.AppendLine($"procEmi_B26=0{vazio}");
                    tx2.AppendLine($"verProc_B27=000{vazio}");

                    tx2.AppendLine($"CRT_C21=3{vazio}");

                    tx2.AppendLine($"CNPJ_C02=08187168000160{vazio}");
                    tx2.AppendLine($"xNome_C03=TecnoSpeed{vazio}");
                    tx2.AppendLine($"xFant_C04=TecnoSpeed{vazio}");
                    tx2.AppendLine($"xLgr_C06=Avenida Duque de Caxias{vazio}");
                    tx2.AppendLine($"nro_C07=882{vazio}");
                    tx2.AppendLine($"xCPL_C08=Salas 102 e 909{vazio}");
                    tx2.AppendLine($"xBairro_C09=Centro{vazio}");
                    tx2.AppendLine($"cMun_C10=4115200{vazio}");
                    tx2.AppendLine($"xMun_C11=Maringá{vazio}");
                    tx2.AppendLine($"UF_C12=PR{vazio}");
                    tx2.AppendLine($"CEP_C13=87020025{vazio}");
                    tx2.AppendLine($"cPais_C14=1058{vazio}");
                    tx2.AppendLine($"xPais_C15=Brasil{vazio}");

                    tx2.AppendLine($"IE_C17=9044016688{vazio}");


                    tx2.AppendLine($"CNPJ_E02=00169604000166{vazio}");
                    tx2.AppendLine($"xNome_E04=NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL{vazio}");
                    tx2.AppendLine($"xLgr_E06=RUA DO CENTRO{vazio}");
                    tx2.AppendLine($"nro_E07=897{vazio}");
                    tx2.AppendLine($"xBairro_E09=CENTRO{vazio}");
                    tx2.AppendLine($"cMun_E10=4302303{vazio}");
                    tx2.AppendLine($"xMun_E11=Bom Jesus{vazio}");
                    tx2.AppendLine($"UF_E12=RS{vazio}");
                    tx2.AppendLine($"CEP_E13=87500000{vazio}");
                    tx2.AppendLine($"cPais_E14=1058{vazio}");
                    tx2.AppendLine($"xPais_E15=BRASIL{vazio}");
                    tx2.AppendLine($"fone_E16=445555555{vazio}");
                    tx2.AppendLine($"indIEDest_E16a=1{vazio}");
                    tx2.AppendLine($"IE_E17=1570027061{vazio}");

                    int n = 1;
                    foreach (var produto in nota.ITENS_VENDA)
                    {
                        tx2.AppendLine($"INCLUIRITEM");

                        tx2.AppendLine($"nItem_H02={n++}");
                        tx2.AppendLine($"cProd_I02=1{vazio}");
                        tx2.AppendLine($"CEAN_I03={vazio}");
                        tx2.AppendLine($"xProd_I04=ADAPTADOR WIRELESS USB INTELBRAS  54 MBPS WBG901 (OT0909002580){vazio}");
                        tx2.AppendLine($"NCM_I05=84183000{vazio}");
                        tx2.AppendLine($"CFOP_I08=6101{vazio}");
                        tx2.AppendLine($"uCom_I09=Un{vazio}");
                        tx2.AppendLine($"qCom_I10=10.0000{vazio}");
                        tx2.AppendLine($"vUnCom_I10a=15.52{vazio}");
                        tx2.AppendLine($"vProd_I11=155.20{vazio}");
                        tx2.AppendLine($"cEANTrib_I12={vazio}");
                        tx2.AppendLine($"uTrib_I13=Un{vazio}");
                        tx2.AppendLine($"qTrib_I14=10.0000{vazio}");
                        tx2.AppendLine($"vUnTrib_I14a=15.5200{vazio}");
                        tx2.AppendLine($"indTot_I17b=1{vazio}");

                        tx2.AppendLine($"orig_N11=0{vazio}");

                        tx2.AppendLine($"CST_N12=00{vazio}");
                        tx2.AppendLine($"MODBC_N13=3{vazio}");
                        tx2.AppendLine($"VBC_N15=155.20{vazio}");
                        tx2.AppendLine($"PICMS_N16=12.00{vazio}");
                        tx2.AppendLine($"VICMS_N17=18.62{vazio}");
                        tx2.AppendLine($"modBCST_N18=4{vazio}");
                        tx2.AppendLine($"vBCST_N21=0.00{vazio}");
                        tx2.AppendLine($"pICMSST_N22=0.00{vazio}");
                        tx2.AppendLine($"vICMSST_N23=0.00{vazio}");

                        tx2.AppendLine($"CST_Q06=99{vazio}");
                        tx2.AppendLine($"VBC_Q07=155.20{vazio}");
                        tx2.AppendLine($"PPIS_Q08=5.00{vazio}");
                        tx2.AppendLine($"VPIS_Q09=7.76{vazio}");

                        tx2.AppendLine($"CST_S06=99{vazio}");
                        tx2.AppendLine($"VBC_S07=155.20{vazio}");
                        tx2.AppendLine($"PCOFINS_S08=5.00{vazio}");
                        tx2.AppendLine($"VCOFINS_S11=7.76{vazio}");


                        tx2.AppendLine($"SALVARITEM");
                    }

                    tx2.AppendLine($"vBC_W03=155.20{vazio}");
                    tx2.AppendLine($"vICMS_W04=18.62{vazio}");
                    tx2.AppendLine($"vICMSDeson_W04a=0.00{vazio}");
                    tx2.AppendLine($"vBCST_W05=0.00{vazio}");
                    tx2.AppendLine($"vST_W06=0.00{vazio}");
                    tx2.AppendLine($"vProd_W07=155.20{vazio}");
                    tx2.AppendLine($"vFrete_W08=0.00{vazio}");
                    tx2.AppendLine($"vSeg_W09=0.00{vazio}");
                    tx2.AppendLine($"vDesc_W10=0.00{vazio}");
                    tx2.AppendLine($"vII_W11=0.00{vazio}");
                    tx2.AppendLine($"vIPI_W12=0.00{vazio}");
                    tx2.AppendLine($"vPIS_W13=7.76{vazio}");
                    tx2.AppendLine($"vCOFINS_W14=7.76{vazio}");
                    tx2.AppendLine($"vOutro_W15=0.00{vazio}");
                    tx2.AppendLine($"vNF_W16=155.20{vazio}");


                    tx2.AppendLine($"modFrete_X02=0{vazio}");

                    tx2.AppendLine($"INCLUIRCOBRANCA{vazio}");
                    tx2.AppendLine($"nFat_Y03=2000{vazio}");
                    tx2.AppendLine($"vOrig_Y04=500.00{vazio}");
                    tx2.AppendLine($"vDesc_Y05=100.00{vazio}");
                    tx2.AppendLine($"vLiq_Y06=400.00{vazio}");

                    tx2.AppendLine($"nDup_Y08=1{vazio}");
                    tx2.AppendLine($"dVenc_Y09=2009-04-25{vazio}");
                    tx2.AppendLine($"vDup_Y10=100.00{vazio}");

                    tx2.AppendLine($"nDup_Y08=2{vazio}");
                    tx2.AppendLine($"dVenc_Y09=2009-04-25{vazio}");
                    tx2.AppendLine($"vDup_Y10=100.00{vazio}");

                    tx2.AppendLine($"nDup_Y08=3{vazio}");
                    tx2.AppendLine($"dVenc_Y09=2009-04-25{vazio}");
                    tx2.AppendLine($"vDup_Y10=100.00{vazio}");

                    tx2.AppendLine($"nDup_Y08=4{vazio}");
                    tx2.AppendLine($"dVenc_Y09=2009-04-25{vazio}");
                    tx2.AppendLine($"vDup_Y10=100.00{vazio}");
                    tx2.AppendLine($"SALVARCOBRANCA{vazio}");

                    tx2.AppendLine($"infAdFisco_Z02=OBSERVACAO TESTE DA DANFE - FISCO{vazio}");
                    tx2.AppendLine($"infCpl_Z03=OBSERVACAO TESTE DA DANFE CONTRIBUINTE{vazio}");
                    tx2.AppendLine($"EmailDestinatario={vazio}");
                    tx2.AppendLine($"SALVAR");


                    RequisicaoPost(tx2.ToString(), usuario, senha);
                }
            }
        }

        public void RequisicaoPost(string tx2, string usuario, string senha)
        {

            //

            var url = " https://managersaashom.tecnospeed.com.br:7071/ManagerAPIWeb/nfe/envia?CNPJ=08187168000160&grupo=edoc";

            try
            {
                HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url + "&arquivo=" + tx2);

                byte[] credentialBuffer = new UTF8Encoding().GetBytes(usuario + ":" + senha);
                objRequest.Headers["Authorization"] = "Basic " + Convert.ToBase64String(credentialBuffer);

                objRequest.Method = "POST";

                HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();

                Stream stream = objResponse.GetResponseStream();

                Encoding encoding = Encoding.Default;

                StreamReader response = new StreamReader(stream, encoding);

                var retorno = response.ReadToEnd();

                Console.WriteLine(retorno);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            
        }
    }
}
