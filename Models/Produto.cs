using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade_4.Models
{
    public class Produto 
    {
        public int Id{get;set;}
        
        [StringLength(64)]
        public string nome{get;set;}

        [Column(TypeName="DECIMAL(5,2)")]
        public double preco{get;set;}
        
        [StringLength(512)]
        public string imagem{get;set;}
    }
}