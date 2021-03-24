namespace Atividade_4.Models
{
    public class BDmock
    {
        public Produto[] BuscaProdutosNoBDmock()
        {
            Produto[] produtoArray = {new Produto(){Id=0,nome="cimento",preco=50,imagem="So teste"},
                                new Produto(){Id=0,nome="prego",preco=15,imagem="So teste"},
                                new Produto(){Id=0,nome="rejunte",preco=25,imagem="So teste"},
                                new Produto(){Id=0,nome="argamassa",preco=40,imagem="So teste"}};
            return produtoArray;
        }
    }
}
