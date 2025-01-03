namespace PizzasHub.Models;

public class PizzaModel
{
    public int Id { get; set; }
    public string Sabor { get; set; } = string.Empty;
    public string UrlCapa { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public double Valor { get; set; }
}