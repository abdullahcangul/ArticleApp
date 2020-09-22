using ArticleApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DAL.Concrete.Mapping
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {

            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Content).HasMaxLength(600).IsRequired();
            builder.Property(I => I.Img).HasMaxLength(200);

            builder.HasOne(I => I.Article).WithMany(I => I.Comments).HasForeignKey(I => I.ArticleID);


        }
    }
}
