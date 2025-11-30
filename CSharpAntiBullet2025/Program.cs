// تست سریع همه کلاس‌ها
using CSharpAntiBullet2025;

var p = new Person("مهدی", 30);
p.Introduce();

var acc = new BankAccount();
acc.Deposit(1000);
acc.Withdraw(200);
Console.WriteLine(acc.Balance);

Console.WriteLine("سلام دنیا".WordCount());
Console.WriteLine(17.IsPrime());

var point = new Point3D(3, 4, 0);
Console.WriteLine(point.DistanceFromOrigin());