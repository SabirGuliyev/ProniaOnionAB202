﻿using ProniaOnion202.Application.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion202.Application.Abstractions.Services
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryItemDto>> GetAllAsync(int page, int take);

        //Task<GetCategoryDto> GetAsync(int id);
        Task Create(CategoryCreateDto dto);
    }
}
