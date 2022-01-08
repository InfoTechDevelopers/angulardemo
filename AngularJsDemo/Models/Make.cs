using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AngularJsDemo.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Model> Models { get; set; } = new HashSet<Model>();

    }

    public class MakeEntityTypeConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder
                .HasIndex(x => x.Name)
                .IsUnique();

            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasMany(p => p.Models)
                .WithOne(p => p.Make)
                .HasForeignKey(p => p.MakeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
