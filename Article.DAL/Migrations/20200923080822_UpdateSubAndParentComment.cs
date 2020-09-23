using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArticleApp.DAL.Migrations
{
    public partial class UpdateSubAndParentComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Comments_ReplyID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ReplyID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ReplyID",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "ParentCommentId",
                table: "Comments",
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
                column: "CommentDate",
                value: new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CommentDate",
                value: new DateTime(2020, 9, 23, 11, 8, 22, 39, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ParentCommentId",
                table: "Comments",
                column: "ParentCommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Comments_ParentCommentId",
                table: "Comments",
                column: "ParentCommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Comments_ParentCommentId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ParentCommentId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ParentCommentId",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "ReplyID",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 38, 17, 991, DateTimeKind.Local).AddTicks(8391), new DateTime(2020, 9, 22, 23, 38, 17, 990, DateTimeKind.Local).AddTicks(8009), "9836bacb-2560-41b1-bdf4-eb7b3c293183" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(152), new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(140), "465d63d4-0bb8-4225-9524-fc3dbbd7ecd0" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(210), new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(209), "15152fa3-7bda-4183-8ad1-9a2457630d29" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(215), new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(215), "79f52df9-8c07-4919-92f6-cde04b858aff" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LastEditDate", "PublishedDate", "Uid" },
                values: new object[] { new DateTime(2020, 9, 24, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(219), new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(219), "ad292251-0bae-499f-8bd9-6a91908f621f" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentDate",
                value: new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CommentDate",
                value: new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CommentDate",
                value: new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CommentDate",
                value: new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CommentDate",
                value: new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReplyID",
                table: "Comments",
                column: "ReplyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Comments_ReplyID",
                table: "Comments",
                column: "ReplyID",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
