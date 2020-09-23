﻿using ArticleApp.DTO.DTOs.Article;
using ArticleApp.DTO.DTOs.Category;
using ArticleApp.DTO.DTOs.Comment;
using ArticleApp.Entity.Concrete;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleApp.Api.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Article, ArticleDto>().ReverseMap();
            CreateMap<Article, ArticleAddDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryAddDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();
            CreateMap<Comment, CommentAddDto>().ReverseMap();
            CreateMap<Comment, CommentListDto>().ReverseMap();

        }
    }
}
