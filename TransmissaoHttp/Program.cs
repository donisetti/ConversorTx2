using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace TransmissaoHttp
{
    class Program
    {
        static void Main(string[] args)
        {
            string servidor = "https://managersaashom.tecnospeed.com.br";
            string porta = "7071";
            string grupo = "edoc";
            string cnpj = "08187168000160";
            string usuario = "admin";
            string senha = "123mudar";
            string documento = "nfe";
            string api = "envia";

            string arq = "";


            
            using (var streamReader = new StreamReader(@"C:\\Projetos\\Nutryervas\\TX2\\000007.TXT", Encoding.UTF8))
            {
                arq = streamReader.ReadToEnd();
            }



            //RequisicaoGet(arq, usuario, senha);
            RequisicaoPost(arq, usuario, senha);

        }

        private static void RequisicaoPost(string tx2, string usuario, string senha)
        {

            //

            var url = " https://managersaashom.tecnospeed.com.br:7071/ManagerAPIWeb/nfe/envia?CNPJ=08187168000160&grupo=edoc";

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

            Console.ReadLine();
        }

        private static void RequisicaoGet(string url, string tx2, string usuario, string senha)
        {
            //var url = " https://managersaashom.tecnospeed.com.br:7071/ManagerAPIWeb/nfe/envia?CNPJ=08187168000160&grupo=edoc&";

            //// String url = "http://" + edtServidor.Text + ":" + edtPorta.Text + "/ManagerAPIWeb/" + edtDocumento.Text + "/" + edtAPI.Text + "?CNPJ=" + edtCNPJ.Text + "&grupo=" + edtGrupo.Text + "&" + edtEnvio.Text;
            //HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            //byte[] credentialBuffer = new UTF8Encoding().GetBytes(usuario + ":" + senha);
            //objRequest.Headers["Authorization"] = "Basic " + Convert.ToBase64String(credentialBuffer);

            //objRequest.Method = "GET";

            //HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();

            //Stream stream = objResponse.GetResponseStream();

            //Encoding encoding = Encoding.Default;

            //StreamReader response = new StreamReader(stream, encoding);

            //var retorno =  response.ReadToEnd();
        }

        
    }
}
