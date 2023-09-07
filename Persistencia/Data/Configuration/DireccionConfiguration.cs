using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
    public class DireccionConfiguration : IEntityTypeConfiguration<Direccion>
    {
    public void Configure(EntityTypeBuilder<Direccion> builder)
    {
        builder.ToTable("addresses");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("Id_Address")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.Neigborhood)
                .HasColumnName("Nameneigborhood")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                
            builder.Property(p => p.TypeWay)
                .HasColumnName("TypeWay")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

     
            builder.Property(p => p.NumberWay)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("NumberWay")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                  builder.Property(p => p.QuadrantPrefix)
                .HasColumnName("QuadranPrefix")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                  builder.Property(p => p.NumberVenereableWay)
                .HasColumnName("NameVenereableWay")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                  builder.Property(p => p.NumberPlate)
                .HasColumnName("NumberPlate")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();


                 builder.HasOne(p => p.Persona)
                .WithMany(p => p.Direcciones)
                .HasForeignKey(p => p.Id_Pa);

    }
}