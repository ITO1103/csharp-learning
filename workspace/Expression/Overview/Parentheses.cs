// 意図を明確にするために括弧を使ってください

int score = 80;
int bonus = 15;
int threshold = 90;
bool eligible = true;

// &&は||より優先されるので，(eligible && score + bonus > threshold) || bonus > 20として評価される
bool result1 = eligible && score + bonus > threshold || bonus > 20;

// 括弧で評価するまとまりを明示する
bool result2 = (eligible && score + bonus > threshold) || bonus > 20;

Console.WriteLine(result1);
Console.WriteLine(result2);

bool isAdmin = false;
bool isOwner = true;

// &&が||より優先されるので，(isAdmin && isOwner) || trueとして評価される
bool access1 = isAdmin && isOwner || true;

// 括弧内の||を先に評価する
bool access2 = isAdmin && (isOwner || true);

Console.WriteLine(access1);
Console.WriteLine(access2);