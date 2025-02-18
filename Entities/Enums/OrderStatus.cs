namespace Pedidos.Entities.Enums;

public enum OrderStatus : int
{
    PendingPayement = 0,       //Enums, gosto sempre de lembrar da "Máquina de Estados", sempre penso nesses enums dessa forma.
    Processing = 1,
    Shipped = 2,
    Delivered = 3
}