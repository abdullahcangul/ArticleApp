using ArticleApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DAL.Concrete.EntityFrameworkCore.Mapping
{
    public class ArticleMap: IEntityTypeConfiguration<Article>
    {
        
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Title).HasMaxLength(250).IsRequired();
            builder.Property(I => I.Content).HasColumnType("ntext").IsRequired();
            builder.Property(I => I.Description).HasMaxLength(250);


        }
    }
}
