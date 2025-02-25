namespace Pedidos.Entities;

public class Client
{
    public string Name { get; set; }
    public string Email { get; set; }   //Propriedades
    public DateTime BirthDate { get; set; }

    public Client()
    {
    }
                                                //Construtores
    public Client(string name, string email, DateTime birthDate)
    {
        Name = name;
        Email = email;
        BirthDate = birthDate;
        
    }

    public override string ToString()
    {
        return Name
               + ", ("
               + BirthDate.ToString("dd/MM/yyyy") //Nada de novo aqui
               + ") - "
               + Email;
    }
}