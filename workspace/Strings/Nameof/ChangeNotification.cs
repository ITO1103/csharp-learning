// プロパティ変更通知

using System.ComponentModel;
using System.Runtime.CompilerServices;

var person = new Person();

// PropertyChangedイベントが発生したときに実行する処理を登録する
// どのプロパティが変更されたかをPropertyNameで取得する
// イベントハンドラーでは習慣的にeという変数名を使う
person.PropertyChanged += (_, e) => Console.WriteLine($"changed: {e.PropertyName}");

// Nameを変更するとPropertyChangedイベントが発生する
person.Name = "Ada";
person.Name = "Grace";


public sealed class Person : INotifyPropertyChanged
{
    // Nameプロパティの実際の値を保持するフィールド
    private string _name = "";

    public string Name
    {
        get => _name;

        set
        {
            // 同じ値なら変更されていないので何もしない
            if (_name == value)
            {
                return;
            }

            // 新しい値を保存する
            _name = value;

            // Nameが変更されたことを通知する
            OnPropertyChanged(nameof(Name));
        }
    }

    // プロパティが変更されたことを通知するイベント
    public event PropertyChangedEventHandler? PropertyChanged;

    // PropertyChangedイベントを発生させる
    // propertyNameには変更されたプロパティ名が入る
    private void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
    
}