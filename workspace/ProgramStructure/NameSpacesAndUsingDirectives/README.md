名前空間とusingディレクティブ  
https://learn.microsoft.com/ja-jp/dotnet/csharp/fundamentals/program-structure/namespaces

`using static`を使うと，指定した型のstaticメンバーを，型名を省略して使用できる．

```csharp
using static System.Math;

double result = Pow(2, 3);
```

通常は，

```csharp
double result = Math.Pow(2, 3);
```

と書く．

`static`は，オブジェクトを`new`して作成しなくても，型そのものから使用できるもの．

そのため，`Math.Pow()`のようなstaticメソッドは，

```csharp
Math.Pow(2, 3);
```

のように型名から直接呼び出せる．

`using static System.Math;`を書くと，その`Math.`も省略できる．