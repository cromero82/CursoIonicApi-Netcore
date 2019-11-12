using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CursoIonicApi.Model
{
    public partial class NoticiasDbContext : DbContext
    {
        public NoticiasDbContext()
        {
        }

        public NoticiasDbContext(DbContextOptions<NoticiasDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Noticia> Noticia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=DESKTOP-G7N93RD\\SQLEXPRESS; Trusted_Connection=False; MultipleActiveResultSets=true; database=Noticias;user id=appusermvc;password=usuario123*");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>(entity =>
            {
                entity.Property(e => e.AutorId).HasColumnName("AutorID");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Noticia>(entity =>
            {
                entity.Property(e => e.NoticiaId).HasColumnName("NoticiaID");

                entity.Property(e => e.AutorId).HasColumnName("AutorID");

                entity.Property(e => e.Contenido).IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
