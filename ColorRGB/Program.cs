using System;

// README.md를 읽고 코드를 작성하세요.




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