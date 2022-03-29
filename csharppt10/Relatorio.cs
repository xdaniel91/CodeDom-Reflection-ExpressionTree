#pragma warning disable 
#define RELATORIO_RESUMIDO

using Newtonsoft.Json;
using System.Diagnostics;

namespace csharppt10
{
    interface IRelatorio
    {
        string Nome { get; set; }
        void Imprimir();
    }

    internal class Relatorio : IRelatorio
    {
        public string Nome { get; set; }
        readonly IList<Venda> vendas;

        public Relatorio(string nome)
        {
            this.Nome = nome;
            vendas = JsonConvert.DeserializeObject<List<Venda>>(File.ReadAllText("Vendas.json"));
        }

        public void Imprimir()
        {
            Cabecalho();
#if RELATORIO_RESUMIDO
            ListagemResumida();
#endif
#if RELATORIO_DETALHADO
            ListagemDetalhada();
#endif
            Console.WriteLine();
        }

        [Conditional("RELATORIO_RESUMIDO")]
        void Cabecalho()
        {
            Console.WriteLine(this.Nome);
            Console.WriteLine("=============================");
        }

        [Conditional("RELATORIO_DETALHADO")]
        void ListagemDetalhada()
        {
            var atributoBase = Attribute.GetCustomAttribute(typeof(Venda), typeof(FormatoDetalhadoAttribute));
            FormatoDetalhadoAttribute myAtributo = (FormatoDetalhadoAttribute)atributoBase;
            var str = myAtributo.Formato;

            Console.WriteLine("Data          Produto         Preco       TipoPagamento Nome                  Cidade                Região                Pais");
            Console.WriteLine("==========================================================================================================================================");

            foreach (var venda in vendas)
            {
                Console.WriteLine(str, venda.Data, venda.Produto, venda.Preco, venda.TipoPagamento, venda.Nome, venda.Cidade, venda.Estado, venda.Pais);
            }
            Console.WriteLine();
        }

        [Conditional("RELATORIO_RESUMIDO")]
        void ListagemResumida()
        {
            var atributoBase = Attribute.GetCustomAttribute(typeof(Venda), typeof(FormatoResumidoAttribute));
            FormatoResumidoAttribute myAttribute = (FormatoResumidoAttribute)atributoBase;
            var str = myAttribute.Formato;

            Console.WriteLine("Data          Produto         Preco       TipoPagamento   ");
            Console.WriteLine("==========================================================");

            foreach (var venda in vendas)
            {
                Console.WriteLine( str, venda.Data, venda.Produto, venda.Preco, venda.TipoPagamento);
            }
            Console.WriteLine();
        }
    }
}