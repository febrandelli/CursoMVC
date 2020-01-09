using CursoMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public Produto produto { get; set; }
        public int Quantidade { get; set; }        

        public void Entrada()
        {
            
        }
    }
}
