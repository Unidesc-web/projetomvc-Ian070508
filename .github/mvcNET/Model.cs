using System;
using System.Collections.Generic;
using System.Linq;

// Exemplo Copilot

public class Carro
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

@if (Model == null)
{
    <p>No products available.</p>
}
else
{
    <p>Number of products: @Model.Count</p>
}