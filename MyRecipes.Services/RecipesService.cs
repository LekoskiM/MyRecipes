﻿using MyRecipes.Data;
using MyRecipes.Repository.Interfaces;
using MyRecipes.Services.Interfaces;
using System.Collections.Generic;

namespace MyRecipes.Services
{
    public class RecipesService : IRecipesService
    {
        public IRecipeRepository RecipesRepo { get; set; }

        public RecipesService(IRecipeRepository recipesRepo)
        {
            RecipesRepo = recipesRepo;
        }

        public List<Recipe> GetAll()
        {
            var recipes = RecipesRepo.GetAll();

            return recipes;
        }

        public Recipe GetById(int id)
        {
            var recipe = RecipesRepo.GetById(id);

            return recipe;
        }

        public Recipe GetRecipeDetails(int id)
        {
            var recipe = RecipesRepo.GetById(id);

            recipe.Views += 1;
            RecipesRepo.Update(recipe);

            return recipe;
        }

        public void CreateRecipe(Recipe recipe)
        {
            RecipesRepo.Add(recipe);
        }

        public List<Recipe> GetByTitle(string title)
        {
            var recipes = RecipesRepo.GetByTitle(title);
            return recipes;
        }

        public void Delete(int id)
        {
            RecipesRepo.Delete(id);
        }

        public void UpdateRecipe(Recipe recipe)
        {
            RecipesRepo.Update(recipe);
        }
    }
}
