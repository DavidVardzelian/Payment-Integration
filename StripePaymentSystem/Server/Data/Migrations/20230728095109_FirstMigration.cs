using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { "1118d34b-6e2c-4f5d-b622-2a2a5871c362", "Product 7 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/7/500", 7000L, "Product 7" },
                    { "18f2a1f3-a92e-4f0c-8755-35e6f38dcf6c", "Product 3 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/3/500", 3000L, "Product 3" },
                    { "1edab72e-a2ed-41a5-9890-670884dbd65d", "Product 5 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/5/500", 5000L, "Product 5" },
                    { "23b00b78-087e-4b98-b5ba-05edb01065cb", "Product 8 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/8/500", 8000L, "Product 8" },
                    { "3ed5e145-b50a-4564-b9f3-98717fea98d2", "Product 16 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/16/500", 16000L, "Product 16" },
                    { "4bc8c646-9753-4a6b-ba59-309ed5b5489f", "Product 10 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/10/500", 10000L, "Product 10" },
                    { "4fe7c437-1900-4d8a-b78b-89ba17a56573", "Product 19 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/19/500", 19000L, "Product 19" },
                    { "58073f5b-4cbf-4507-9fae-e728f1fde8ae", "Product 13 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/13/500", 13000L, "Product 13" },
                    { "5db1ffa3-07b5-403f-8503-0364927198cc", "Product 14 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/14/500", 14000L, "Product 14" },
                    { "6af72135-a1f2-42c6-ae27-4cc90d65ad2f", "Product 1 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/1/500", 1000L, "Product 1" },
                    { "79e33f48-9410-4fcc-83c5-d5b3115d0b1f", "Product 20 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/20/500", 20000L, "Product 20" },
                    { "88319215-e505-40ec-b7ba-9b95bfad1de0", "Product 9 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/9/500", 9000L, "Product 9" },
                    { "a4adfa48-568f-47d8-b2de-0cc37e765b96", "Product 12 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/12/500", 12000L, "Product 12" },
                    { "b2cb802f-7620-461e-b6e7-0c39891ac45b", "Product 18 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/18/500", 18000L, "Product 18" },
                    { "b9baadfc-c06c-49c1-a0cd-9cd761c5b653", "Product 11 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/11/500", 11000L, "Product 11" },
                    { "e0fef6e1-d010-4f64-9bcf-9eddb112537c", "Product 15 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/15/500", 15000L, "Product 15" },
                    { "eeeb3763-286f-4f4b-9312-3e9e98a1171b", "Product 17 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/17/500", 17000L, "Product 17" },
                    { "f5ec669f-3c32-49a1-8b44-3761873f091c", "Product 2 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/2/500", 2000L, "Product 2" },
                    { "fc09a836-4619-4a64-a098-d92ff9e14c10", "Product 4 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/4/500", 4000L, "Product 4" },
                    { "fe27cae6-e443-4767-9aab-33eecf196ba5", "Product 6 description. This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/6/500", 6000L, "Product 6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
