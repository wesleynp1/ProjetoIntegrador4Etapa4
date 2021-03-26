using System.Linq;
using System.Collections.Generic;

namespace Atividade_4.Models
{
    public class ProdutosVendasContext
    {
        public List<Produto> BuscaProdutosNoBD()
        {
            using(var contextBD = new BDcontext())
            {
                return contextBD.Produtos.ToList<Produto>();
            }
        }

        public int InsereProdutoNoBD(Produto p)
        {
            using(var contextBD = new BDcontext())
            {
                contextBD.Add(p);
                contextBD.SaveChanges();
                return p.Id;
            }
        }
    }
}
