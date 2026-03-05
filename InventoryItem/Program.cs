using System;

// README.md를 읽고 코드를 작성하세요.

InventoryItem[] inven = new InventoryItem[5];
inven[0] = new InventoryItem("검", 3.5, 1500);
inven[1] = new InventoryItem("방패", 5, 1200);
inven[2] = new InventoryItem("포션", 0.3, 50);
inven[3] = new InventoryItem("활", 1.8, 1300);
inven[4] = new InventoryItem("투구", 2, 800);

double totalWeight = 0;
int totalPrice = 0;

string mostExpensiveItem = "";
int highestPrice = int.MinValue;
string lightestItem = "";
double lowestWeight = double.MaxValue;

Console.WriteLine($"=== 인벤토리 목록 ===");
foreach (var item in inven)
{
    item.DisplayInfo();
    totalWeight += item.Weight;
    totalPrice += item.Price;
}

int averagePrice = totalPrice / inven.Length;

Console.WriteLine($"\n=== 인벤토리 통계 ===");
Console.WriteLine($"전체 무게: {totalWeight:f1}kg");
Console.WriteLine($"전체 가격: {totalPrice}골드");
Console.WriteLine($"평균 가격: {averagePrice}골드");
foreach (var item in inven)
{
    if (item.Price > highestPrice)
    {
        highestPrice = item.Price;
        mostExpensiveItem = item.Name;
    }

    if (item.Weight < lowestWeight)
    {
        lowestWeight = item.Weight;
        lightestItem = item.Name;
    }
}
Console.WriteLine($"가장 비싼 아이템: {mostExpensiveItem}");
Console.WriteLine($"가장 가벼운 아이템: {lightestItem}");

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