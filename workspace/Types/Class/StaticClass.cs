// 静的クラス

// staticクラスはインスタンス化できない
// 静的メンバーのみ
double circumference = MathHelpers.CircleCircumference(5.0);
Console.WriteLine($"Circumference: {circumference:F2}");


static class MathHelpers
{
    public static double CircleCircumference(double radius) => 2 * Math.PI * radius;
}