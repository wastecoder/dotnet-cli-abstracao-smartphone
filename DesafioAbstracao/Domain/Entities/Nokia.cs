using DesafioAbstracao.Domain.Enums;

namespace DesafioAbstracao.Domain.Entities;

public sealed class Nokia : Smartphone
{
    public Nokia(
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

        Console.WriteLine($">> Baixando o APK de {nomeAplicativo} pelo Nokia Store...");
        Console.WriteLine($"> {nomeAplicativo} ({tamanhoAplicativo} MB) instalado com sucesso no Nokia!");
        ArmazenamentoDisponivel -= tamanhoAplicativo;
    }

    public void TirarFoto()
    {
        if (!Ligado)
        {
            Console.WriteLine("> O Nokia está desligado. Ligue-o para usar a câmera.");
            return;
        }

        Console.WriteLine(">> Tirando foto com o Nokia...");
        if (ArmazenamentoDisponivel > 0)
        {
            ArmazenamentoDisponivel -= 1;
            Console.WriteLine("> Foto tirada e armazenada com sucesso!");
        }
        else
        {
            Console.WriteLine("> Sem espaço suficiente para salvar a foto!");
        }
    }
}
