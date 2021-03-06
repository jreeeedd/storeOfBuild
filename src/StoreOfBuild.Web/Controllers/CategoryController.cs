﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreOfBuild.Domain.Dtos;
using StoreOfBuild.Domain.Products;
using StoreOfBuild.Web.Models;

namespace StoreOfBuild.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryStore _categoryStore;

        public CategoryController(CategoryStore categoryStore){
            
            _categoryStore = categoryStore;
        }
        public IActionResult Index()
        {
            return View();
        }

         public IActionResult CreateOrEdit()
        {
            return View();
        }

        [HttpPost]
         public IActionResult CreateOrEdit(CategoryDto dto)
        {
            _categoryStore.Store(dto);
            return View();
        }

      
    }
}
