using System;
using System.Text.Json;

using RestSharp;

RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest pokeRequest = new RestRequest("pokemon/ditto");
IRestResponse response = pokeClient.Get(pokeRequest);

// Console.WriteLine(response.StatusCode);
// Console.WriteLine(response.Content);

Pokemon poke = JsonSerializer.Deserialize<Pokemon>(response.Content);

Console.WriteLine($"Name: {poke.name}   id: {poke.id}");

Console.WriteLine(poke.held_items[0].item.name);

Console.ReadLine();