using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AngularJsDemo.Models
{
    public class Model
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int HorsePower { get; set; }

        public int MakeId { get; set; }

        public virtual Make? Make { get; set; }

        public string? ImageUrl { get; set; }

        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();

    }


    public class ModelEntityTypeConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder
                .HasIndex(x => new { x.Name, x.MakeId })
                .IsUnique();

            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(x => x.ImageUrl)
                .IsRequired()
                .HasMaxLength(2048)
                .IsUnicode(false);

            builder
                .HasMany(p => p.Cars)
                .WithOne(p => p.Model)
                .HasForeignKey(p => p.ModelId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }

}
