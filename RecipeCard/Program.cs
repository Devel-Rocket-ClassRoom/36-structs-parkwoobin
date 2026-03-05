using System;

// README.md를 읽고 코드를 작성하세요.

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







struct Ingredient
{
    public string Name;
    public double Amount;
    public string Unit;

    public Ingredient(string name, double amount, string unit)
    {
        this.Name = name;
        this.Amount = amount;
        this.Unit = unit;
    }
}

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        this.Name = name;
        this.Servings = servings;
        this.Ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        Console.WriteLine("재료:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient.Name}: {ingredient.Amount}{ingredient.Unit}");
        }
    }

    public RecipeCard ScaleRecipe(int newServings)
    {
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Ingredients[i].Amount *= ((double)newServings / Servings);
        }
        return this;
    }
}