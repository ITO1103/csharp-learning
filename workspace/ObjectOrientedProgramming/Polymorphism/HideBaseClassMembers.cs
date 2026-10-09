// 新しいメンバーで基底クラス メンバーを隠ぺいする

using System;

DerivedClass B = new();
B.DoWork(); // DerivedClass側のDoWorkを呼び出す
Console.WriteLine($"Derived: {B.WorkField}, {B.WorkProperty}");

// 同じオブジェクトを基底クラス型で受け取る
BaseClass A = B;
A.DoWork(); // BaseClass側のDoWorkを呼び出す
Console.WriteLine($"Base: {A.WorkField}, {A.WorkProperty}");

public class BaseClass
{
    public void DoWork() { WorkField++; }
    public int WorkField;
    public int WorkProperty
    {
        get { return 0; }
    }
}

public class DerivedClass : BaseClass
{
    // 基底クラスのDoWorkを隠す
    public new void DoWork() { WorkField++; }
    public new int WorkField; // 基底クラスとは別のフィールド
    public new int WorkProperty
    {
        get { return 1; }
    }
}
