//1. Classe**

//Uma** classe** é um molde ou modelo para criar objetos. Ela define os **atributos** (características) e **métodos** (ações) que os objetos terão.

class Carro
{
    // Atributos (características)
    public string marca;
    public string modelo;
    public int ano;

    // Método (ação)
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Carro: {marca} {modelo}, Ano: {ano}");
    }
}