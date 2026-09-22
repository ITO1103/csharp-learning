// レコードの継承

var p1 = new Student("BOB", "BabyOnBoard", 1);
Console.WriteLine(p1);

Person person = p1;
Console.WriteLine(person); // person.からはGradeLevelにアクセスできない
// コンパイル時の型はPersonだが実体はStudent
// Console.WriteLine(person)では実体であるStudentのToString()が呼ばれるため，GradeLevelも表示される

public record Person(string FirstName, string LastName);
// PersonからStudentに継承 = StudentはPersonの一種
public record Student(string FirstName, string LastName, int GradeLevel) : Person(FirstName, LastName);