using Finn;
using System.Text.Json;

var finnObj = JsonSerializer.Deserialize<FinnResponse>(File.ReadAllText("finn.json"));
foreach (var doc in (Doc[])finnObj.docs)
{
    Console.WriteLine($"{doc}");
}
Console.ReadKey();