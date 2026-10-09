// 派生クラスで仮想メンバーのオーバーライドを禁止する

using System;

D d = new();
d.DoWork();

C c = d;
c.DoWork();

B b = d;
b.DoWork();

A a = d;
a.DoWork();

public class A
{
    public virtual void DoWork() => Console.WriteLine("A");
}

public class B : A
{
    public override void DoWork() => Console.WriteLine("B");
}

public class C : B
{
    // Cより下の派生クラスでoverrideできなくする
    public sealed override void DoWork() => Console.WriteLine("C");
}

public class D : C
{
    // overrideではなくnewでDoWorkを隠す
    public new void DoWork() => Console.WriteLine("D");
}
