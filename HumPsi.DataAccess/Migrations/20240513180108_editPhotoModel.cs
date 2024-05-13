using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HumPsi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Articles_ArticlesId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Headlines_HeadlinesId",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Photo_ArticlesId",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Photo_HeadlinesId",
                table: "Photo");

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("01ba7970-8b13-4364-9530-4b232037a402"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("208e144b-3a09-4f1e-8d8f-3b06e4e78174"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("45a62589-ec08-47ae-83c0-969b54d6dbd9"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("583508f1-c5de-40b8-9b13-78940a4d2db9"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("6aeb99f8-7580-4cfb-9326-201173b1ff6d"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("7e2ff28b-b27a-4148-9b7f-808d66af82b2"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("998d048b-98e2-464e-b686-b83d625452f1"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("d2bbc481-6908-4dc8-b979-e6398e8b22db"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("f0d70a63-9971-44c5-8f42-61d276e37cac"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("f11cafa8-40b3-4cd2-87d1-b217b3413317"));

            migrationBuilder.DropColumn(
                name: "ArticlesId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "HeadlinesId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "TitlePhotoId",
                table: "Headlines");

            migrationBuilder.InsertData(
                table: "Section",
                columns: new[] { "Id", "TitleSection" },
                values: new object[,]
                {
                    { new Guid("071dc2aa-6390-43d6-9de7-6a300089094b"), "Gastrointestinal" },
                    { new Guid("3d9c683d-f36c-4b54-9785-7a0a01157ee5"), "Cardiovascular" },
                    { new Guid("3e549725-45b8-4b79-98fa-5aa1e099671a"), "Reproductive" },
                    { new Guid("6cb5174e-b47a-4e36-bee4-d7a69af58b93"), "Endocrine" },
                    { new Guid("b6455da2-7c27-4d5a-9cb7-ade0bf471fe0"), "Immunology/Haematology" },
                    { new Guid("c89d29a5-07e2-44a5-a3d7-f1792b5a1f93"), "Respiratory" },
                    { new Guid("dce18de7-942f-4932-8e11-3c898382da00"), "Histology" },
                    { new Guid("ed5f90ac-910c-4d14-8f5a-2f63ffbcc9bc"), "Neurology" },
                    { new Guid("f0537962-9406-496a-a212-314dc18d0c9b"), "Biochemistry" },
                    { new Guid("f76b9295-6e15-4d08-a6ec-51ca700ca6d4"), "Urinary" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("071dc2aa-6390-43d6-9de7-6a300089094b"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("3d9c683d-f36c-4b54-9785-7a0a01157ee5"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("3e549725-45b8-4b79-98fa-5aa1e099671a"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("6cb5174e-b47a-4e36-bee4-d7a69af58b93"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("b6455da2-7c27-4d5a-9cb7-ade0bf471fe0"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("c89d29a5-07e2-44a5-a3d7-f1792b5a1f93"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("dce18de7-942f-4932-8e11-3c898382da00"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("ed5f90ac-910c-4d14-8f5a-2f63ffbcc9bc"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("f0537962-9406-496a-a212-314dc18d0c9b"));

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: new Guid("f76b9295-6e15-4d08-a6ec-51ca700ca6d4"));

            migrationBuilder.AddColumn<Guid>(
                name: "ArticlesId",
                table: "Photo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HeadlinesId",
                table: "Photo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TitlePhotoId",
                table: "Headlines",
                type: "uniqueidentifier",
                nullable: true);

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
                name: "IX_Photo_ArticlesId",
                table: "Photo",
                column: "ArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_HeadlinesId",
                table: "Photo",
                column: "HeadlinesId",
                unique: true,
                filter: "[HeadlinesId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Articles_ArticlesId",
                table: "Photo",
                column: "ArticlesId",
                principalTable: "Articles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Headlines_HeadlinesId",
                table: "Photo",
                column: "HeadlinesId",
                principalTable: "Headlines",
                principalColumn: "Id");
        }
    }
}
