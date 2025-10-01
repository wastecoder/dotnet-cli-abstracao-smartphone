using DesafioAbstracao.Domain.Enums;

namespace DesafioAbstracao.Domain.Entities;

public abstract class Smartphone
{
    public string Numero { get; init; }
    public string Modelo { get; protected init; }
    public string IMEI { get; protected init; }
    public SistemaOperacional SistemaOperacional { get; protected init; }
    public int VersaoSO { get; protected init; }
    public int PorcentagemBateria { get; private set; }
    public int ArmazenamentoTotal { get; protected init; }
    public int ArmazenamentoDisponivel { get; protected set; }
    public bool Ligado { get; private set; }


    public Smartphone(
        string numero,
        string modelo,
        string imei,
        SistemaOperacional sistemaOperacional,
        int versaoSO,
        int armazenamentoTotal)
    {
        if (string.IsNullOrWhiteSpace(numero)) throw new ArgumentException("Número inválido", nameof(numero));
        if (string.IsNullOrWhiteSpace(modelo)) throw new ArgumentException("Modelo inválido", nameof(modelo));
        if (string.IsNullOrWhiteSpace(imei)) throw new ArgumentException("IMEI inválido", nameof(imei));
        if (versaoSO <= 0) throw new ArgumentOutOfRangeException(nameof(versaoSO), "Versão do SO deve ser maior que zero");
        if (armazenamentoTotal <= 0) throw new ArgumentOutOfRangeException(nameof(armazenamentoTotal), "Armazenamento deve ser positivo");
        
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        SistemaOperacional = sistemaOperacional;
        VersaoSO = versaoSO;
        ArmazenamentoTotal = armazenamentoTotal;
        ArmazenamentoDisponivel = armazenamentoTotal; // Começa cheio
        PorcentagemBateria = 100; // Inicia carregado
        Ligado = false;
    }


    public void Ligar()
    {
        Console.WriteLine(">> Ligando...");
        Ligado = true;
    }

    public void Desligar()
    {
        Console.WriteLine(">> Desligando...");
        Ligado = false;
    }

    public void ReceberLigacao()
    {
        Console.WriteLine(">> Recebendo ligação...");
    }

    public void CarregarBateria(int porcentagemBateria)
    {
        PorcentagemBateria = porcentagemBateria;
    }

    public int ObterArmazenamentoUsado()
    {
        return ArmazenamentoTotal - ArmazenamentoDisponivel;
    }
    
    public void ExibirArmazenamento()
    {
        Console.WriteLine("+=======================+");
        Console.WriteLine("|     ARMAZENAMENTO     |");
        Console.WriteLine("+=======================+");
        Console.WriteLine($"| Total: {ArmazenamentoTotal} MB");
        Console.WriteLine($"| Disponível: {ArmazenamentoDisponivel} MB");
        Console.WriteLine($"| Usado: {ObterArmazenamentoUsado()} MB");
        Console.WriteLine("+========================+");
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("+=========================+");
        Console.WriteLine("|       INFORMAÇÕES       |");
        Console.WriteLine("+=========================+");
        Console.WriteLine($"| Número: {Numero}");
        Console.WriteLine($"| Modelo: {Modelo}");
        Console.WriteLine($"| IMEI: {IMEI}");
        Console.WriteLine($"| SO: {SistemaOperacional}");
        Console.WriteLine($"| Versão SO: {VersaoSO}");
        Console.WriteLine($"| Bateria: {PorcentagemBateria}%");
        Console.WriteLine($"| Armazenamento: {ArmazenamentoTotal} MB");
        Console.WriteLine($"| Ligado: {(Ligado ? "Sim" : "Nao")}");
        Console.WriteLine("+=========================+");
    }

    public abstract void InstalarAplicativo(string nomeAplicativo, int tamanhoAplicativo);
}
