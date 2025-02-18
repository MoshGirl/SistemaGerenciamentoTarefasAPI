using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaGerenciamentoTarefasAPI.Model;

namespace SistemaGerenciamentoTarefasAPI.Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> usuarioBuilder)
        {
            usuarioBuilder.HasKey(u => u.UsuarioID);

            usuarioBuilder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(150);

            usuarioBuilder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(150);

            usuarioBuilder.Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(255);

            usuarioBuilder.HasMany(u => u.Tarefas)
                .WithOne(t => t.Usuario)
                .HasForeignKey(t => t.UsuarioID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}