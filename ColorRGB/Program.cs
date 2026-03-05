using System;

// README.md를 읽고 코드를 작성하세요.

ColorRGB red = new ColorRGB(255, 0, 0);
ColorRGB white = new ColorRGB(255, 255, 255);
ColorRGB custom = new ColorRGB(100, 150, 200);

Console.WriteLine("=== RGB 색상 밝기 계산===");

Console.Write($"빨강 - R: {red.R}, G: {red.G}, B: {red.B} → ");
red.GetBrightness();
Console.Write($"흰색 - R: {white.R}, G: {white.G}, B: {white.B} → ");
white.GetBrightness();
Console.Write($"커스텀 - R: {custom.R}, G: {custom.G}, B: {custom.B} → ");
custom.GetBrightness();


struct ColorRGB
{
    public int R;
    public int G;
    public int B;


    public ColorRGB(int v1, int v2, int v3)
    {
        this.R = v1;
        this.G = v2;
        this.B = v3;
    }

    public void GetBrightness()
    {
        int brightness = (R + G + B) / 3;
        Console.WriteLine($"밝기: {brightness}");
    }

}