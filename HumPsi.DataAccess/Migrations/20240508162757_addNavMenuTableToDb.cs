using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HumPsi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addNavMenuTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleSection = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Headlines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitlePhotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headlines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Headlines_Section_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Section",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ShortContentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortContent = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    HeadlinesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Headlines_HeadlinesId",
                        column: x => x.HeadlinesId,
                        principalTable: "Headlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadlinesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ArticlesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Articles_ArticlesId",
                        column: x => x.ArticlesId,
                        principalTable: "Articles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Photo_Headlines_HeadlinesId",
                        column: x => x.HeadlinesId,
                        principalTable: "Headlines",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Section",
                columns: new[] { "Id", "TitleSection" },
                values: new object[,]
                {
                    { new Guid("01ba7970-8b13-4364-9530-4b232037a402"), "Cardiovascular" },
                    { new Guid("208e144b-3a09-4f1e-8d8f-3b06e4e78174"), "Neurology" },
                    { new Guid("45a62589-ec08-47ae-83c0-969b54d6dbd9"), "Immunology/Haematology" },
                    { new Guid("583508f1-c5de-40b8-9b13-78940a4d2db9"), "Respiratory" },
                    { new Guid("6aeb99f8-7580-4cfb-9326-201173b1ff6d"), "Biochemistry" },
                    { new Guid("7e2ff28b-b27a-4148-9b7f-808d66af82b2"), "Gastrointestinal" },
                    { new Guid("998d048b-98e2-464e-b686-b83d625452f1"), "Reproductive" },
                    { new Guid("d2bbc481-6908-4dc8-b979-e6398e8b22db"), "Histology" },
                    { new Guid("f0d70a63-9971-44c5-8f42-61d276e37cac"), "Endocrine" },
                    { new Guid("f11cafa8-40b3-4cd2-87d1-b217b3413317"), "Urinary" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_HeadlinesId",
                table: "Articles",
                column: "HeadlinesId");

            migrationBuilder.CreateIndex(
                name: "IX_Headlines_SectionId",
                table: "Headlines",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_ArticlesId",
                table: "Photo",
                column: "ArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_HeadlinesId",
                table: "Photo",
                column: "HeadlinesId",
                unique: true,
                filter: "[HeadlinesId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Headlines");

            migrationBuilder.DropTable(
                name: "Section");
        }
    }
}
