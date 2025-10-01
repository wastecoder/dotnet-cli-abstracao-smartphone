using DesafioAbstracao.Domain.Entities;
using DesafioAbstracao.Domain.Enums;

namespace DesafioAbstracao.Tests;

public class NokiaTest
{
    public static void Executar()
    {
        TestarLigar();
        TestarExibirInformacoes();
        TestarExibirArmazenamento();
        TestarInstalarAplicativoComSucesso();
        TestarInstalarAplicativoSemEspaco();
        TestarTirarFotoComSucesso();
        TestarTirarFotoSemEspaco();
        TestarTirarFotoComCelularDesligado();
    }

    private static void TestarLigar()
    {
        Console.WriteLine(">>> Ligar Nokia <<<");

        var nokia = CriarNokia();
        nokia.Ligar();

        Console.WriteLine($"> Ligado: {(nokia.Ligado ? "Sim" : "Não")}");
    }

    private static void TestarExibirInformacoes()
    {
        Console.WriteLine("\n>>> Exibir Informações (Nokia) <<<");

        var nokia = CriarNokia();
        nokia.ExibirInformacoes();
    }

    private static void TestarExibirArmazenamento()
    {
        Console.WriteLine("\n>>> Exibir Armazenamento (Nokia) <<<");

        var nokia = CriarNokia();
        nokia.ExibirArmazenamento();
    }

    private static void TestarInstalarAplicativoComSucesso()
    {
        Console.WriteLine("\n>>> Instalar Aplicativo (Sucesso) <<<");

        var nokia = CriarNokia();
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp", 50);

        Console.WriteLine($"> Armazenamento disponível: {nokia.ArmazenamentoDisponivel} MB");
    }

    private static void TestarInstalarAplicativoSemEspaco()
    {
        Console.WriteLine("\n>>> Instalar Aplicativo (Falha - Sem espaço) <<<");

        var nokia = CriarNokia(armazenamentoTotal: 10);
        nokia.Ligar();
        nokia.InstalarAplicativo("Facebook", 20);

        Console.WriteLine($"> Armazenamento disponível: {nokia.ArmazenamentoDisponivel} MB");
    }

    private static void TestarTirarFotoComSucesso()
    {
        Console.WriteLine("\n>>> Tirar Foto (Sucesso) <<<");

        var nokia = CriarNokia();
        nokia.Ligar();
        nokia.TirarFoto();

        Console.WriteLine($"> Armazenamento disponível: {nokia.ArmazenamentoDisponivel} MB");
    }

    private static void TestarTirarFotoSemEspaco()
    {
        Console.WriteLine("\n>>> Tirar Foto (Falha - Sem espaço) <<<");

        var nokia = CriarNokia(armazenamentoTotal: 10);
        nokia.Ligar();
        nokia.InstalarAplicativo("ExemploAplicativoPesado", 10); // Para ocupar o espaço
        nokia.TirarFoto();
    }

    private static void TestarTirarFotoComCelularDesligado()
    {
        Console.WriteLine("\n>>> Tirar Foto (Falha - Celular desligado) <<<");

        var nokia = CriarNokia();
        nokia.TirarFoto();
    }

    // Método auxiliar para criar instâncias de Nokia
    private static Nokia CriarNokia(int armazenamentoTotal = 128)
    {
        return new Nokia(
            numero: "1199999-9999",
            modelo: "Nokia XpressMusic",
            imei: "1234567890",
            sistemaOperacional: SistemaOperacional.Android,
            versaoSO: 14,
            armazenamentoTotal: armazenamentoTotal
        );
    }
}
