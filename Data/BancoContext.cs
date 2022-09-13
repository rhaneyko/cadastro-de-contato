using cadastro_de_contato.Models;
using Microsoft.EntityFrameworkCore;

namespace cadastro_de_contato.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
        }
        public DbSet<ContatoModel> Contatos { get; set; }
       
    }
}
