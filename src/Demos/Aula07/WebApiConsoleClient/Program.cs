// See https://aka.ms/new-console-template for more information
using System.Text.Json;

Console.WriteLine("Hello, World!");




var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7257/Livros");
request.Headers.Add("Accept", "text/plain");
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();

var conteudo = await response.Content.ReadAsStringAsync();

 var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
var meusLivros =  JsonSerializer.Deserialize<List<MeuLivro>>(conteudo, options); 




Console.WriteLine(meusLivros.FirstOrDefault().Nome);





var requestPost = new HttpRequestMessage(HttpMethod.Post, "https://localhost:7257/Livros/NovosLivros");
requestPost.Headers.Add("Accept", "text/plain");

var livroNovo = new MeuLivro{
    Id = 25,
    Nome = "As Crônicas de Nárnia",
    Preco = 25,
    EnglishISBNTest = "qwqasda"
};

var meusLivroString =  JsonSerializer.Serialize(livroNovo); 


// var content = new StringContent(meusLivroString, null, "application/json");


var content = new StringContent("{\n  \"id\": \"111\",\n  \"nome\": \"<string>\",\n  \"isbn\": \"<string>\"\n}", null, null);


request.Content = content;
var responsePost = await client.SendAsync(requestPost);
responsePost.EnsureSuccessStatusCode();
Console.WriteLine(await responsePost.Content.ReadAsStringAsync());
