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

            builder
                .HasData(
                    new Model { Id = 1, MakeId = 1, Name = "Murcielago", HorsePower = 450, ImageUrl = "https://ia.tmgrup.com.tr/eccc3c/628/422/0/27/800/564?u=http://i.tmgrup.com.tr/otohaber/2018/02/01/lamborghini-murcielago-hakkinda-bilgi-verir-misiniz-1517491567467.jpg" },
                    new Model { Id = 2, MakeId = 1, Name = "Aventador", HorsePower = 500, ImageUrl = "https://arabahaber.com.tr/wp-content/uploads/2018/08/Lamborghini-Aventador-SVJ.jpg" },
                    new Model { Id = 3, MakeId = 1, Name = "Hurracan", HorsePower = 450, ImageUrl = "https://wikiimg.tojsiabtv.com/wikipedia/commons/thumb/d/d3/Lamborghini_Hurac%C3%A1n_LP_610_(17913080973).jpg/1280px-Lamborghini_Hurac%C3%A1n_LP_610_(17913080973).jpg" },
                    new Model { Id = 4, MakeId = 2, Name = "Enzo", HorsePower = 450, ImageUrl = "https://www.webtekno.com/images/editor/default/0002/67/62ef54c4fcd5a4b120892e2d58a292a651234db5.jpeg" },
                    new Model { Id = 5, MakeId = 2, Name = "Italia", HorsePower = 450, ImageUrl = "https://cdn1.ntv.com.tr/gorsel/Kd6k41vauU2QSAs05QvTuw.jpg?width=960&mode=crop&scale=both" },
                    new Model { Id = 6, MakeId = 3, Name = "Veyron", HorsePower = 450, ImageUrl = "https://staticb.yolcu360.com/blog/wp-content/uploads/2021/04/08212643/Bugatti_Veyron_16-960x483.jpg" },
                    new Model { Id = 7, MakeId = 4, Name = "Agera R", HorsePower = 450, ImageUrl = "https://ajansotomobil.com/media/news/542.jpg" },
                    new Model { Id = 8, MakeId = 4, Name = "Jesco", HorsePower = 450, ImageUrl = "https://images.hgmsites.net/hug/koenigsegg-jesko-pre-production-model_100799636_h.jpg" },
                    new Model { Id = 9, MakeId = 5, Name = "500sec", HorsePower = 450, ImageUrl = "https://i1.wp.com/www.klasikotom.com/wp-content/uploads/2017/11/mercedes-500sec-amg-27.jpg?ssl=1" }
                );

        }
    }

}
