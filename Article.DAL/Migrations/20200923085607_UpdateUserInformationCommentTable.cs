using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArticleApp.DAL.Migrations
{
    public partial class UpdateUserInformationCommentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "AuthorEmail",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Comments",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 25, 11, 56, 7, 439, DateTimeKind.Local).AddTicks(7193), new DateTime(2020, 9, 23, 11, 56, 7, 439, DateTimeKind.Local).AddTicks(6813), "a639c662-6b38-4533-bd93-422112aa0f58" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 25, 11, 56, 7, 439, DateTimeKind.Local).AddTicks(8910), new DateTime(2020, 9, 23, 11, 56, 7, 439, DateTimeKind.Local).AddTicks(8903), "a526eeba-088a-4060-bba5-6f17527ac3ac" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 25, 11, 56, 7, 439, DateTimeKind.Local).AddTicks(8966), new DateTime(2020, 9, 23, 11, 56, 7, 439, DateTimeKind.Local).AddTicks(8965), "802588ed-4076-4168-8c80-01eed13fbfcd" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 25, 11, 56, 7, 439, DateTimeKind.Local).AddTicks(8973), new DateTime(2020, 9, 23, 11, 56, 7, 439, DateTimeKind.Local).AddTicks(8972), "d6f2faf4-d95c-45d1-860c-3a716d3a17e6" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 25, 11, 56, 7, 439, DateTimeKind.Local).AddTicks(8978), new DateTime(2020, 9, 23, 11, 56, 7, 439, DateTimeKind.Local).AddTicks(8977), "3c15b7ae-1062-4c97-8ca6-a70456de36a3" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorEmail", "AuthorName", "CommentDate" },
                values: new object[] { "abdullahcangul@gmail.com", "Abdullah CANGUL", new DateTime(2020, 9, 23, 11, 56, 7, 440, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorEmail", "AuthorName", "CommentDate" },
                values: new object[] { "abdullahcangul@gmail.com", "Abdullah CANGUL", new DateTime(2020, 9, 23, 11, 56, 7, 440, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorEmail", "AuthorName", "CommentDate" },
                values: new object[] { "abdullahcangul@gmail.com", "Abdullah CANGUL", new DateTime(2020, 9, 23, 11, 56, 7, 440, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorEmail", "AuthorName", "CommentDate" },
                values: new object[] { "abdullahcangul@gmail.com", "Abdullah CANGUL", new DateTime(2020, 9, 23, 11, 56, 7, 440, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorEmail", "AuthorName", "CommentDate" },
                values: new object[] { "abdullahcangul@gmail.com", "Abdullah CANGUL", new DateTime(2020, 9, 23, 11, 56, 7, 440, DateTimeKind.Local).AddTicks(1603) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorEmail",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Comments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 25, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(4955), new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(4565), "fdd2204c-f69d-4bfc-9e61-116461e41cd6" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 25, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(6615), new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(6607), "48b64056-538a-4f69-869b-df3c353f8ba8" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 25, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(6675), new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(6673), "de53928a-664b-455e-b46b-e2e8d8510e1c" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 25, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(6681), new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(6680), "382273a9-dfba-4eee-a07f-c091d0364c38" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 25, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(6763), new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(6762), "c97dbcd6-c82d-47f6-b442-5be95ab737a2" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "Img" },
                values: new object[] { new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(8218), "image.png" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "Img" },
                values: new object[] { new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(9088), "image.png" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "Img" },
                values: new object[] { new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(9111), "image.png" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "Img" },
                values: new object[] { new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(9112), "image.png" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "Img" },
                values: new object[] { new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(9113), "image.png" });
        }
    }
}
