using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sistema.Datos.Mapping.Almacen
{
    using Microsoft.EntityFrameworkCore;
    using Sistema.Entidades.Almacen;
    public class CategoriaMap : IEntityTypeConfiguration<Categoria> 
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria").HasKey(c => c.CategoriaId);
            builder.Property(c => c.Nombre).HasMaxLength(50);
            builder.Property(c => c.Descripcion).HasMaxLength(256);
        }
    }
}
