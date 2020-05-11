﻿using MyRecipes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRecipes.Repository
{
    public class RecipeRepository
    {
        public List<Recipe> Recipes { get; set; }

        public RecipeRepository()
        {
            Recipes = new List<Recipe>();

            var recipe = new Recipe()
            {
                Id = 1,
                ImageUrl = "https://images.media-allrecipes.com/userphotos/560x315/3374022.jpg",
                Title = "Puff Pastry Waffles",
                Description = "Add puff pastry to the list of good things you can snackify in your waffle iron. Although they don't puff up as much as oven-baked puff pastry, they turn out crispy on the outside and tender on the inside, and they take only minutes to make. Serve hot or at room temperature with syrup, fruit, Nutella®, fruit preserves, or nut butter.",
                Ingredients = new List<string> { "Ingredient 1", "Ingredient 2" },
                Directions = new List<string> { "Cook", "Eat" }

            };

            var recipe2 = new Recipe()
            {
                Id = 2,
                ImageUrl = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F1092268.jpg&w=596&h=596&c=sc&poi=face&q=85",
                Title = "Tennessee Meatloaf",
                Description = "My Grandmother 'Nanaw' Rowan made the most delicious meatloaf in the state. When she passed away, she didn't leave me her recipe, but she left me the desire to recreate it. I think this is it, in flavor and texture. Don't let the number of ingredients discourage you. It's part of the magic in creating a masterpiece!",
                Ingredients = new List<string> { "Ingredient 3", "Ingredient 4" },
                Directions = new List<string> { "Cook", "Eat" }
            };

            Recipes.Add(recipe);
            Recipes.Add(recipe2);
        }

        public List<Recipe> GetAll()
        {
            return Recipes;
        }

        public Recipe GetById(int id)
        {
            return Recipes.FirstOrDefault(x => x.Id == id);
        }
    }
}