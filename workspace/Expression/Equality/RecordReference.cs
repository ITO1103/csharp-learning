// 参照型メンバーを持つレコード

var playlist1 = new Playlist("Chill", new List<string> { "Song A", "Song B" });
var playlist2 = new Playlist("Chill", new List<string> { "Song A", "Song B" });

// Tracksは別々のListインスタンスなので，record全体としては等しくない
Console.WriteLine(playlist1.Equals(playlist2));

// SequenceEqualを使えばList内の各要素を比較できる
Console.WriteLine(playlist1.Tracks.SequenceEqual(playlist2.Tracks));


record Playlist(string Name, List<string> Tracks);