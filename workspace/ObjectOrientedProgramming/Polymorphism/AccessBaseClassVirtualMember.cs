// 派生クラスから基底クラスの仮想メンバーにアクセスする

using System;

Derived derived = new();
derived.DoWork();

public class Base
{
    public virtual void DoWork() => Console.WriteLine("Base");
}

public class Derived : Base
{
    public override void DoWork()
    {
        Console.WriteLine("Derived");
        // 基底クラスの実装も呼び出す
        base.DoWork();
    }
}
