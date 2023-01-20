
string[] namn = new string[5];
Console.WriteLine("Skriv in 5 namn");

namn[0] = "";
namn[1] = "";
namn[2] = "";
namn[3] = "";
namn[4] = "";

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("namn:");
    namn[i] = Console.ReadLine();

}
Console.WriteLine($"Du skrev in {namn[0]}, {namn[1]}, {namn[2]}, {namn[3]}, {namn[4]}");