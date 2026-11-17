using System.Text.Json.Serialization;

namespace lab10_kalinichenko_IKM724a.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    [JsonIgnore]
    public Category? Category { get; set; }
}