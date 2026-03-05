using System;

// README.md를 읽고 코드를 작성하세요.

struct InventoryItem
{
    public string Name;
    public double Weight;
    public int Price;

    public InventoryItem(string name, double weight, int price)
    {
        this.Name = name;
        this.Weight = weight;
        this.Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{Name} - 무게: {Weight}kg, 가격: {Price}골드");
    }
}