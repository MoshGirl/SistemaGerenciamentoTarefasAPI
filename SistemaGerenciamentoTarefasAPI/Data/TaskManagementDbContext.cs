using Microsoft.EntityFrameworkCore;
using SistemaGerenciamentoTarefasAPI.Data.Mapping;
using SistemaGerenciamentoTarefasAPI.Model;

namespace SistemaGerenciamentoTarefasAPI.Data
{
    public class TaskManagementDbContext : DbContext
    {
        public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext> options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new TarefaMapping());
        }
    }
}