

using Microsoft.VisualBasic;

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


Console.WriteLine("Other line");
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValues = "a";
Console.WriteLine(myValues != "a");
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

// Cara o Cruz

Random coin = new Random();
int flip = coin.Next(0,2);
Console.WriteLine((flip ==0) ? "heads": "tails");


// Permisos

string permission = "Admin|Manager";
int level = 55;

string msg = (permission.Contains("Admin") && level > 55) ? "Welcome, Super Admin user." : "Welcome, Admin user.";
Console.WriteLine(msg);

