// タスクを返すメソッドの例外

using System;
using System.Threading.Tasks;

try
{
    await ToastBreadAsync(5, 1);
}
catch (ArgumentException ex) // 引数の検証はTaskを返す前に行われる
{
    Console.WriteLine(ex.ParamName);
}

try
{
    await ToastBreadAsync(2, 2_001);
}
catch (InvalidOperationException ex) // 非同期処理中の例外はTaskに入る
{
    Console.WriteLine(ex.Message);
}

static Task<Toast> ToastBreadAsync(int slices, int toastTime)
{
    if (slices is < 1 or > 4) // slicesが1未満または4より大きい場合
    {
        throw new ArgumentException(
            "You must specify between 1 and 4 slices of bread.",
            nameof(slices));
    }

    if (toastTime < 1)
    {
        throw new ArgumentException(
            "Toast time is too short.", nameof(toastTime));
    }

    return ToastBreadAsyncCore(slices, toastTime);

    // 非同期処理中にスローした例外は返すTaskに格納する
    static async Task<Toast> ToastBreadAsyncCore(int slices, int time)
    {
        for (int slice = 0; slice < slices; slice++)
        {
            Console.WriteLine("Putting a slice of bread in the toaster");
        }

        await Task.Delay(time);

        if (time > 2_000)
        {
            throw new InvalidOperationException("The toaster is on fire!");
        }

        Console.WriteLine("Toast is ready!");
        return new Toast();
    }
}

public class Toast;
