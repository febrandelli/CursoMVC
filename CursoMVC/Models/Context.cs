using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoMVC.Models;

namespace CursoMVC.Models
{
    public class Context :DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-MA7IQHE;Initial Catalog=MVC;Integrated Security=True");

        }
        public DbSet<CursoMVC.Models.Estoque> Estoque { get; set; }
    }
}
