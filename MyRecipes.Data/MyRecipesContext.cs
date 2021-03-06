﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipes.Data
{
    public class MyRecipesContext : DbContext
    {
        public MyRecipesContext(DbContextOptions<MyRecipesContext> options) : base(options)
        {
        }

        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<User> Users{ get; set; }
    }
}
