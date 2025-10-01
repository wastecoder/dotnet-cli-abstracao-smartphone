using DesafioAbstracao.Domain.Entities;
using DesafioAbstracao.Domain.Enums;

namespace DesafioAbstracao.Tests;

public class IphoneTest
{
    public static void Executar()
    {
        TestarLigar();
        TestarExibirInformacoes();
        TestarExibirArmazenamento();
        TestarInstalarAplicativoComSucesso();
        TestarInstalarAplicativoSemEspaco();
        TestarUsarFaceIdComSucesso();
        TestarUsarFaceIdComCelularDesligado();
    }

    private static void TestarLigar()
    {
        Console.WriteLine(">>> Ligar iPhone <<<");

        var iphone = CriarIphone();
        iphone.Ligar();

        Console.WriteLine($"> Ligado: {(iphone.Ligado ? "Sim" : "Não")}");
    }
    
    
    private static void TestarExibirInformacoes()
    {
        Console.WriteLine("\n>>> Exibir Informações (iPhone) <<<");

        var iphone = CriarIphone();
        iphone.ExibirInformacoes();
    }

    private static void TestarExibirArmazenamento()
    {
        Console.WriteLine("\n>>> Exibir Armazenamento (iPhone) <<<");

        var iphone = CriarIphone();
        iphone.ExibirArmazenamento();
    }

    private static void TestarInstalarAplicativoComSucesso()
    {
        Console.WriteLine("\n>>> Instalar Aplicativo (Sucesso) <<<");

        var iphone = CriarIphone();
        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram", 50);

        Console.WriteLine($"> Armazenamento disponível: {iphone.ArmazenamentoDisponivel} MB");
    }

    private static void TestarInstalarAplicativoSemEspaco()
    {
        Console.WriteLine("\n>>> Instalar Aplicativo (Falha - Sem espaço) <<<");

        var iphone = CriarIphone(armazenamentoTotal: 20);
        iphone.Ligar();
        iphone.InstalarAplicativo("Final Cut Pro", 200);

        Console.WriteLine($"> Armazenamento disponível: {iphone.ArmazenamentoDisponivel} MB");
    }

    private static void TestarUsarFaceIdComSucesso()
    {
        Console.WriteLine("\n>>> Usar FaceID (Sucesso) <<<");

        var iphone = CriarIphone();
        iphone.Ligar();
        iphone.UsarFaceID();
    }

    private static void TestarUsarFaceIdComCelularDesligado()
    {
        Console.WriteLine("\n>>> Usar FaceID (Falha - Celular desligado) <<<");

        var iphone = CriarIphone();
        iphone.UsarFaceID();
    }

    // Método auxiliar para criar instâncias de iPhone
    private static Iphone CriarIphone(int armazenamentoTotal = 128)
    {
        return new Iphone(
            numero: "1198888-8888",
            modelo: "iPhone 15 Pro",
            imei: "IPHONE-1234567890",
            sistemaOperacional: SistemaOperacional.iOS,
            versaoSO: 17,
            armazenamentoTotal: armazenamentoTotal
        );
    }
}
