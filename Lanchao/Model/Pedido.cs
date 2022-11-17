namespace Lanchao.Model;

public class Pedido
{
    public int Numero {get; set;}

    public DateTime DataHora {get; set;}

    public string Observacao {get; set;}

    public string Origem {get; set;}

    public int TempoEntrega {get; set;}

    public Cliente Consumidor {get; set;}

    public List<Produto> Produtos {get; set;}

}