// 名前空間宣言の外側にusing命令を配置する

using System;
// namespace宣言の外では最上位のAzure名前空間を参照する
using Azure;

namespace ExampleOutsideNamespace
{
    public class Awesome
    {
        public void Stuff()
        {
            WaitUntil wait = WaitUntil.Completed;
            Console.WriteLine(wait);
        }
    }
}

namespace CoolStuff.AwesomeFeature
{
    // global::で最上位のAzure名前空間を指定する
    using global::Azure;

    public class Awesome
    {
        public void Stuff()
        {
            WaitUntil wait = WaitUntil.Completed;
            Console.WriteLine(wait);
        }
    }
}

namespace Azure
{
    public enum WaitUntil
    {
        Completed
    }
}

namespace CoolStuff.Azure
{
    public class SecretsManagement
    {
        public string FetchFromKeyVault(string vaultId, string secretId) =>
            $"{vaultId}/{secretId}";
    }
}

public class Program
{
    public static void Main()
    {
        new ExampleOutsideNamespace.Awesome().Stuff();
        new CoolStuff.AwesomeFeature.Awesome().Stuff();
    }
}
