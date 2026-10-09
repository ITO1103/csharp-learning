// 仮想メンバー

using System;

DerivedClass B = new();
B.DoWork();
Console.WriteLine(B.WorkProperty);

// DerivedClassを基底クラス型の変数で受け取る
BaseClass A = B;
A.DoWork(); // 実行時の型に対応するDoWorkを呼び出す
Console.WriteLine(A.WorkProperty);

public class BaseClass
{
    public virtual void DoWork() => Console.WriteLine("BaseClass");
    public virtual int WorkProperty => 0;
}

public class DerivedClass : BaseClass
{
    // 基底クラスのDoWorkをoverrideする
    public override void DoWork() => Console.WriteLine("DerivedClass");
    public override int WorkProperty => 1;
}
