using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AngularJsDemo.Models
{

    public enum TransmissionTypes
    {
        Manual, Sequential, Automatic, CVT, Triptronic
    }

    public class Car
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public string? Color { get; set; }
        public TransmissionTypes Transmission { get; set; }
        public int MinDays { get; set; }
        public int Year { get; set; }

        public virtual Model? Model { get; set; }

    }


    public class CarEntityTypeConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {

            builder
                .Property(x => x.Color)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
