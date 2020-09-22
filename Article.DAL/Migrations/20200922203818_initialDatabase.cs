using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArticleApp.DAL.Migrations
{
    public partial class initialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 250, nullable: false),
                    Content = table.Column<string>(type: "ntext", nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    State = table.Column<int>(nullable: false),
                    LastEditDate = table.Column<DateTime>(nullable: false),
                    PublishedDate = table.Column<DateTime>(nullable: false),
                    isActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(maxLength: 200, nullable: true),
                    Content = table.Column<string>(maxLength: 600, nullable: false),
                    CommentDate = table.Column<DateTime>(nullable: false),
                    ArticleID = table.Column<int>(nullable: false),
                    ReplyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_ReplyID",
                        column: x => x.ReplyID,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategory",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false),
                    ArticleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategory", x => new { x.ArticleId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ArticleCategory_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "Description", "LastEditDate", "PublishedDate", "State", "Title", "Uid", "isActive" },
                values: new object[,]
                {
                    { 1, "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]", "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.", new DateTime(2020, 9, 24, 23, 38, 17, 991, DateTimeKind.Local).AddTicks(8391), new DateTime(2020, 9, 22, 23, 38, 17, 990, DateTimeKind.Local).AddTicks(8009), 2, "Walter Mears", "9836bacb-2560-41b1-bdf4-eb7b3c293183", true },
                    { 2, "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]", "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.", new DateTime(2020, 9, 24, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(152), new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(140), 2, "Dwight D. Eisenhower", "465d63d4-0bb8-4225-9524-fc3dbbd7ecd0", true },
                    { 3, "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]", "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.", new DateTime(2020, 9, 24, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(210), new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(209), 2, "Richard Nixon", "15152fa3-7bda-4183-8ad1-9a2457630d29", true },
                    { 4, "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]", "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.", new DateTime(2020, 9, 24, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(215), new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(215), 2, "Richard Nixon", "79f52df9-8c07-4919-92f6-cde04b858aff", true },
                    { 5, "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]", "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.", new DateTime(2020, 9, 24, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(219), new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(219), 2, "Richard Nixon", "ad292251-0bae-499f-8bd9-6a91908f621f", true }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Health" },
                    { 2, "Geography " },
                    { 3, "History " },
                    { 4, "Technology" },
                    { 5, "Mathematics" }
                });

            migrationBuilder.InsertData(
                table: "ArticleCategory",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleID", "CommentDate", "Content", "Img", "ReplyID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(1357), "Sound Good", "image.png", null },
                    { 2, 1, new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(2185), " Good", "image.png", null },
                    { 3, 2, new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(2205), "Well", "image.png", null },
                    { 4, 2, new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(2206), "Not Good", "image.png", null },
                    { 5, 4, new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(2208), "Maybe Sound Good", "image.png", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategory_CategoryId",
                table: "ArticleCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleID",
                table: "Comments",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReplyID",
                table: "Comments",
                column: "ReplyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleCategory");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
