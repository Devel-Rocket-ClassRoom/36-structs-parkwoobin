using System;

// README.md를 읽고 코드를 작성하세요.


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