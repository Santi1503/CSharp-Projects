var random = new Random();
var value = random.Next(1, 10);

string heads = "heads";
string tails = "tails";

Console.WriteLine($"The coin ended: {(value <= 5 ? heads : tails)}");
Console.WriteLine(value);


/* Solutions from the course

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

-----------------------------------------------------------------------------

Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");
*/