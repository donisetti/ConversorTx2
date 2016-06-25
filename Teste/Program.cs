using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransmissaoNFE;


namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Servico HTTP");
            var nfe = new ServicoHtttp();

            nfe.TransmitirNFe();           

            Console.ReadLine();
        }
    }
}
