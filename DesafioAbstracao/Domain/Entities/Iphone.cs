using DesafioAbstracao.Domain.Enums;

namespace DesafioAbstracao.Domain.Entities;

public sealed class Iphone : Smartphone
{
    public Iphone(
        string numero,
        string modelo,
        string imei,
        SistemaOperacional sistemaOperacional,
        int versaoSO,
        int armazenamentoTotal
    ) : base(numero, modelo, imei, sistemaOperacional, versaoSO, armazenamentoTotal)
    { }


    public override void InstalarAplicativo(string nomeAplicativo, int tamanhoAplicativo)
    {
        if (string.IsNullOrWhiteSpace(nomeAplicativo))
        {
            Console.WriteLine("> Nome do aplicativo inválido.");
            return;
        }

        if (ArmazenamentoDisponivel < tamanhoAplicativo)
        {
            Console.WriteLine($"> Sem espaço disponível para instalar {nomeAplicativo}.");
            return;
        }

        Console.WriteLine($">> Baixando {nomeAplicativo} da App Store...");
        Console.WriteLine($"> {nomeAplicativo} ({tamanhoAplicativo} MB) instalado com sucesso no iPhone!");
        ArmazenamentoDisponivel -= tamanhoAplicativo;
    }

    public void UsarFaceID()
    {
        if (!Ligado)
        {
            Console.WriteLine("> O iPhone está desligado. Ligue-o para usar o Face ID.");
            return;
        }

        Console.WriteLine(">> Olhando para o iPhone...");
        Console.WriteLine(">> Face ID reconhecido com sucesso!");
    }
}
