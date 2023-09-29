using Microsoft.EntityFrameworkCore;
using ProjetoJulio3.Models;
using ProjetoJulio3.Data.Map;


namespace ProjetoJulio3.Data
{
    public class SistemaTarefasDBContex : DbContext

    {
        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }



    }
}
