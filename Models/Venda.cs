using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Atividade_4.Models
{
    public class Venda
    {
        public int Id{get;set;}
        
        public DateTime data{get;set;}
        
        public int quantidade{get;set;}   

        public int IdProduto{get;set;}
    }
}