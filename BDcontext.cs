using Microsoft.EntityFrameworkCore;

namespace Atividade_4.Models
{
    public class BDcontext : DbContext
    {
        public DbSet<Produto> Produtos{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=ProjetoIntegrador;Uid=root;Pwd=;");
        }
    }
}