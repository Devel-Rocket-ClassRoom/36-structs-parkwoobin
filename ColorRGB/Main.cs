using System;

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