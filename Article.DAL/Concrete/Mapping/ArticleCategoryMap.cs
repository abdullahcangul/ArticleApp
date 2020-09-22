using ArticleApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DAL.Concrete.Mapping
{
    class ArticleCategoryMap : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.HasKey( ac =>new { ac.ArticleId,ac.CategoryId});
            builder.HasOne(I => I.Article).WithMany(I => I.ArticleCategories).HasForeignKey(I=>I.ArticleId);
            builder.HasOne(I => I.Category).WithMany(I => I.ArticleCategories).HasForeignKey(I=>I.CategoryId); 
        }
    }
}
