// null 許容値型を宣言する

// ?を付けると値型でもnullを入れられる
int? age = null;

// 値が入っている状態でも使える
double? price = 9.99;

// boolでもnullを扱える
bool? isActive = null;

// 後から値を代入することもできる
age = 30;

// 配列の各要素にもnullを入れられる
int?[] scores = [100, null, 85, null, 72];