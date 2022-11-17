namespace Lanchao.Model;

public class Cliente 
{
    public int Id {get; set;}

    public string Nome {get; set;}

    public string Telefone {get; set;}

    public string Endereco {get; set;} 

    public string Email {get; set;}

    public List<Pedido> Pedidos {get; set;}
    
}