// イベント処理

Form2 form2 = new();
Form1 form1 = new();

form2.RaiseClick(new Point(10, 20));
form1.RaiseClick(new Point(30, 40));

public class Form2 : ClickSource
{
    public Form2()
    {
        // 後で解除しないイベントにはラムダ式を使う
        this.Click += (s, e) =>
            Console.WriteLine(e.Location);
    }
}

public class Form1 : ClickSource
{
    public Form1()
    {
        // メソッド名を指定してイベント処理を登録する
        this.Click += new EventHandler<SampleMouseEventArgs>(Form1_Click);
    }

    void Form1_Click(object? sender, SampleMouseEventArgs e)
    {
        Console.WriteLine(e.Location);
    }
}

public class ClickSource
{
    public event EventHandler<SampleMouseEventArgs>? Click;

    public void RaiseClick(Point location)
    {
        Click?.Invoke(this, new SampleMouseEventArgs(location));
    }
}

public class SampleMouseEventArgs(Point location) : EventArgs
{
    public Point Location { get; } = location;
}

public record Point(int X, int Y);
