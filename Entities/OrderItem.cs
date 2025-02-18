namespace Pedidos.Entities;

public class OrderItem
{
    public int Quantity { get; set; }
    public double Price { get; set; }    //Propriedades
    
    public Product Product { get; set; }
    

    public OrderItem()
    {
    }
                                        //Construtores
    public OrderItem(int quantity, double price, Product product)
    {
        Quantity = quantity;
        Price = price;
        Product = product;
    }

    public double SubTotal()
    {
        return  Price * Quantity;  
    }

    public override string ToString()
    {
        return Product.Name
            + ", $"
            + Price.ToString("F2")
            + ", " + Quantity
            + ", Subtotal: $" + SubTotal().ToString("F2");
    }
    
}
