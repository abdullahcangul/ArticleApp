﻿// <auto-generated />
using System;
using ArticleApp.DAL.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArticleApp.DAL.Migrations
{
    [DbContext(typeof(ArticleAppContext))]
    [Migration("20200922203818_initialDatabase")]
    partial class initialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArticleApp.Entity.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime>("LastEditDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Uid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]",
                            Description = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.",
                            LastEditDate = new DateTime(2020, 9, 24, 23, 38, 17, 991, DateTimeKind.Local).AddTicks(8391),
                            PublishedDate = new DateTime(2020, 9, 22, 23, 38, 17, 990, DateTimeKind.Local).AddTicks(8009),
                            State = 2,
                            Title = "Walter Mears",
                            Uid = "9836bacb-2560-41b1-bdf4-eb7b3c293183",
                            isActive = true
                        },
                        new
                        {
                            Id = 2,
                            Content = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]",
                            Description = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.",
                            LastEditDate = new DateTime(2020, 9, 24, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(152),
                            PublishedDate = new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(140),
                            State = 2,
                            Title = "Dwight D. Eisenhower",
                            Uid = "465d63d4-0bb8-4225-9524-fc3dbbd7ecd0",
                            isActive = true
                        },
                        new
                        {
                            Id = 3,
                            Content = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]",
                            Description = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.",
                            LastEditDate = new DateTime(2020, 9, 24, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(210),
                            PublishedDate = new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(209),
                            State = 2,
                            Title = "Richard Nixon",
                            Uid = "15152fa3-7bda-4183-8ad1-9a2457630d29",
                            isActive = true
                        },
                        new
                        {
                            Id = 4,
                            Content = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]",
                            Description = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.",
                            LastEditDate = new DateTime(2020, 9, 24, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(215),
                            PublishedDate = new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(215),
                            State = 2,
                            Title = "Richard Nixon",
                            Uid = "79f52df9-8c07-4919-92f6-cde04b858aff",
                            isActive = true
                        },
                        new
                        {
                            Id = 5,
                            Content = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]",
                            Description = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.",
                            LastEditDate = new DateTime(2020, 9, 24, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(219),
                            PublishedDate = new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(219),
                            State = 2,
                            Title = "Richard Nixon",
                            Uid = "ad292251-0bae-499f-8bd9-6a91908f621f",
                            isActive = true
                        });
                });

            modelBuilder.Entity("ArticleApp.Entity.Concrete.ArticleCategory", b =>
                {
                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ArticleId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ArticleCategory");

                    b.HasData(
                        new
                        {
                            ArticleId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            ArticleId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            ArticleId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            ArticleId = 3,
                            CategoryId = 2
                        });
                });

            modelBuilder.Entity("ArticleApp.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Health"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Geography "
                        },
                        new
                        {
                            Id = 3,
                            Name = "History "
                        },
                        new
                        {
                            Id = 4,
                            Name = "Technology"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mathematics"
                        });
                });

            modelBuilder.Entity("ArticleApp.Entity.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(600)")
                        .HasMaxLength(600);

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int?>("ReplyID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArticleID");

                    b.HasIndex("ReplyID");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleID = 1,
                            CommentDate = new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(1357),
                            Content = "Sound Good",
                            Img = "image.png"
                        },
                        new
                        {
                            Id = 2,
                            ArticleID = 1,
                            CommentDate = new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(2185),
                            Content = " Good",
                            Img = "image.png"
                        },
                        new
                        {
                            Id = 3,
                            ArticleID = 2,
                            CommentDate = new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(2205),
                            Content = "Well",
                            Img = "image.png"
                        },
                        new
                        {
                            Id = 4,
                            ArticleID = 2,
                            CommentDate = new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(2206),
                            Content = "Not Good",
                            Img = "image.png"
                        },
                        new
                        {
                            Id = 5,
                            ArticleID = 4,
                            CommentDate = new DateTime(2020, 9, 22, 23, 38, 17, 992, DateTimeKind.Local).AddTicks(2208),
                            Content = "Maybe Sound Good",
                            Img = "image.png"
                        });
                });

            modelBuilder.Entity("ArticleApp.Entity.Concrete.ArticleCategory", b =>
                {
                    b.HasOne("ArticleApp.Entity.Concrete.Article", "Article")
                        .WithMany("ArticleCategories")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArticleApp.Entity.Concrete.Category", "Category")
                        .WithMany("ArticleCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticleApp.Entity.Concrete.Comment", b =>
                {
                    b.HasOne("ArticleApp.Entity.Concrete.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArticleApp.Entity.Concrete.Comment", "Reply")
                        .WithMany()
                        .HasForeignKey("ReplyID");
                });
#pragma warning restore 612, 618
        }
    }
}
