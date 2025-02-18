namespace Pedidos.Entities;

public class Product
{
    public string Name { get; set; }     //Propriedades e construtores, aqui realmente não tem nada de interessante
    public double Price { get; set; }

    public Product()
    {
    }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
    
    
}