using System;

Ingredient[] ingredients = new Ingredient[]
{
    new Ingredient("스파게티면", 200, "g"),
    new Ingredient("토마토소스", 150, "ml"),
    new Ingredient("양파", 1, "개"),
    new Ingredient("마늘", 3, "쪽")
};

RecipeCard recipe = new RecipeCard("토마토 파스타", 2, ingredients);
Console.WriteLine("=== 원본 레시피 ===");
recipe.PrintRecipe();

Console.WriteLine("\n=== 4인분 레시피 ===");
RecipeCard scaledRecipe = recipe.ScaleRecipe(4);
scaledRecipe.PrintRecipe();