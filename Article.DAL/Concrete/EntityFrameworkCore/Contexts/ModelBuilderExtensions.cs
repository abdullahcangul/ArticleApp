using ArticleApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DAL.Concrete.Contexts
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
             new Category()
             {
                 Id = 1,
                 Name = "Health",
             },
            new Category()
            {
                Id = 2,
                Name = "Geography "
            },
             new Category()
             {
                 Id = 3,
                 Name = "History "
             },
             new Category()
             {
                 Id = 4,
                 Name = "Technology"
             },
            new Category()
            {
                Id = 5,
                Name = "Mathematics"
            });
            modelBuilder.Entity<Article>().HasData(
                new Article()
                {
                    Id=1,
                    Title = "Walter Mears",
                    State = Core.Entities.State.Draft,
                    PublishedDate = DateTime.Now,
                    LastEditDate = DateTime.Now.AddDays(2),
                    Content = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]",
                    Description = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.",
                    Uid = Guid.NewGuid().ToString(),
                    isActive = true,
                    
                },
                new Article()
                 {
                    Id=2,
                    Title = "Dwight D. Eisenhower",
                    State = Core.Entities.State.Draft,
                    PublishedDate = DateTime.Now,
                    LastEditDate = DateTime.Now.AddDays(2),
                    Content = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]",
                    Description = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.",
                    Uid = Guid.NewGuid().ToString(),
                    isActive = true,
                },
                new Article()
                {
                    Id=3,
                    Title = "Richard Nixon",
                    State = Core.Entities.State.Draft,
                    PublishedDate = DateTime.Now,
                    LastEditDate = DateTime.Now.AddDays(2),
                    Content = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]",
                    Description = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.",
                    Uid = Guid.NewGuid().ToString(),
                    isActive = true,
                },
                new Article()
                {
                    Id=4,
                    Title = "Richard Nixon",
                    State = Core.Entities.State.Draft,
                    PublishedDate = DateTime.Now,
                    LastEditDate = DateTime.Now.AddDays(2),
                    Content = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]",
                    Description = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.",
                    Uid = Guid.NewGuid().ToString(),
                    isActive = true,
                },
                new Article()
                {
                    Id=5,
                    Title = "Richard Nixon",
                    State = Core.Entities.State.Draft,
                    PublishedDate = DateTime.Now,
                    LastEditDate = DateTime.Now.AddDays(2),
                    Content = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher. He was one of the reporters, featured in the 1973 book The Boys on the Bus,[2] who covered the 1972 presidential election between Richard Nixon and George McGovern. He won the 1977 Pulitzer Prize for National Reporting for his coverage of the 1976 Presidential campaign and election.[3] Mears retired from his career as a political reporter, editor, and news executive in 2001. In 2016 he joined the Osher Lifelong Learning Institute at Duke University, as a volunteer instructor, teaching classes on election campaigns; he had previously taught undergraduate classes in journalism.[4]",
                    Description = "Walter R. Mears (born January 11, 1935)[1] is an American journalist, author, and teacher.",
                    Uid = Guid.NewGuid().ToString(),
                    isActive = true,
                });

            modelBuilder.Entity<Comment>().HasData(
                new Comment()
                {
                    Id=1,
                    ArticleID=1,
                    CommentDate=DateTime.Now,
                    Content="Sound Good",
                    AuthorEmail="abdullahcangul@gmail.com",
                    AuthorName="Abdullah CANGUL"
                    
                },
                new Comment()
                {
                    Id=2,
                    ArticleID=1,
                    CommentDate=DateTime.Now,
                    Content=" Good",
                    AuthorEmail = "abdullahcangul@gmail.com",
                    AuthorName = "Abdullah CANGUL"

                },
                new Comment()
                {
                    Id=3,
                    ArticleID=2,
                    CommentDate=DateTime.Now,
                    Content="Well",
                    AuthorEmail = "abdullahcangul@gmail.com",
                    AuthorName = "Abdullah CANGUL"

                },
                new Comment()
                {
                    Id=4,
                    ArticleID=2,
                    CommentDate=DateTime.Now,
                    Content="Not Good",
                    AuthorEmail = "abdullahcangul@gmail.com",
                    AuthorName = "Abdullah CANGUL"

                },
                new Comment()
                {
                    Id=5,
                    ArticleID=4,
                    CommentDate=DateTime.Now,
                    Content="Maybe Sound Good",
                    AuthorEmail = "abdullahcangul@gmail.com",
                    AuthorName = "Abdullah CANGUL"

                });

            modelBuilder.Entity<ArticleCategory>().HasData(
                new ArticleCategory()
                {
                    ArticleId = 1,
                    CategoryId = 1
                },
                new ArticleCategory()
                {
                    ArticleId = 1,
                    CategoryId = 2
                },
                new ArticleCategory()
                {
                    ArticleId = 2,
                    CategoryId = 1
                },
                new ArticleCategory()
                {
                    ArticleId = 3,
                    CategoryId = 2
                }
                );

        }
    }
}
