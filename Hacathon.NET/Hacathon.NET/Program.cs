using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Hacathon.NET.Models;

// Wrote in net6.0

try
{
    // Read data
    var mapText = File.ReadAllText("./map.json");
    Console.WriteLine($"Input: {mapText}");
    var map = JsonSerializer.Deserialize<Map>(mapText);

    if (map is default(Map))
        throw new Exception("input map should be uploaded.");

    // This is where the magic will happen
    var results = GenerateMovement(map).ToArray();

    // Write data
    var resultText = JsonSerializer.Serialize(results);
    Console.WriteLine($"Output: {resultText}");
    File.WriteAllText("./result.json", resultText);
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}

IEnumerable<Position> GenerateMovement(Map map)
{
    throw new NotImplementedException();
}