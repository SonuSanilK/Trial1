Console.WriteLine("Enter two numbers: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int t = 0; Console.WriteLine($" a = {a} and b = {b}");
t = a;
a = b;
b = t;
Console.WriteLine("............After swapping............");
Console.WriteLine($" a = {a} and b = {b}");

