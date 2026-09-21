// default 表現

// intのdefaultは0
int defaultInt = default;
// boolの場合はfalse
bool defaultBool = default;
// string?の場合はnull
string? defaultString = default;

// 条件式でdefaultを使用する場合
var limit = (args.Length > 0) ? int.Parse(args[0]) : default(int);