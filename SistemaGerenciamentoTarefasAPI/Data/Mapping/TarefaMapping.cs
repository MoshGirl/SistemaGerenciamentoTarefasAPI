using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGerenciamentoTarefasAPI.Model;

namespace SistemaGerenciamentoTarefasAPI.Data.Mapping
{
    public class TarefaMapping : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(t => t.TarefaID);

            builder.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(1);

            builder.Property(t => t.DataDeCriacao)
                .IsRequired();

            builder.Property(t => t.DataAlteracao)
                .IsRequired(false);

            builder.Property(t => t.DataConclusao)
               .IsRequired(false);

            // Relacionamento com a tabela Usuario
            builder.HasOne(t => t.Usuario)
                .WithMany(u => u.Tarefas)
                .HasForeignKey(t => t.UsuarioID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}