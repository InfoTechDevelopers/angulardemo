using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularJsDemo.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Lamborghini" },
                    { 2, "Ferrari" },
                    { 3, "Bugatti" },
                    { 4, "Koenigsegg" },
                    { 5, "Mercedes" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "HorsePower", "ImageUrl", "MakeId", "Name" },
                values: new object[,]
                {
                    { 1, 450, "https://ia.tmgrup.com.tr/eccc3c/628/422/0/27/800/564?u=http://i.tmgrup.com.tr/otohaber/2018/02/01/lamborghini-murcielago-hakkinda-bilgi-verir-misiniz-1517491567467.jpg", 1, "Murcielago" },
                    { 2, 500, "https://arabahaber.com.tr/wp-content/uploads/2018/08/Lamborghini-Aventador-SVJ.jpg", 1, "Aventador" },
                    { 3, 450, "https://wikiimg.tojsiabtv.com/wikipedia/commons/thumb/d/d3/Lamborghini_Hurac%C3%A1n_LP_610_(17913080973).jpg/1280px-Lamborghini_Hurac%C3%A1n_LP_610_(17913080973).jpg", 1, "Hurracan" },
                    { 4, 450, "https://www.webtekno.com/images/editor/default/0002/67/62ef54c4fcd5a4b120892e2d58a292a651234db5.jpeg", 2, "Enzo" },
                    { 5, 450, "https://cdn1.ntv.com.tr/gorsel/Kd6k41vauU2QSAs05QvTuw.jpg?width=960&mode=crop&scale=both", 2, "Italia" },
                    { 6, 450, "https://staticb.yolcu360.com/blog/wp-content/uploads/2021/04/08212643/Bugatti_Veyron_16-960x483.jpg", 3, "Veyron" },
                    { 7, 450, "https://ajansotomobil.com/media/news/542.jpg", 4, "Agera R" },
                    { 8, 450, "https://images.hgmsites.net/hug/koenigsegg-jesko-pre-production-model_100799636_h.jpg", 4, "Jesco" },
                    { 9, 450, "https://i1.wp.com/www.klasikotom.com/wp-content/uploads/2017/11/mercedes-500sec-amg-27.jpg?ssl=1", 5, "500sec" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
