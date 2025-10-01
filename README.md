# 📱 Sistema de Abstração de Smartphones em C# – CLI

Este projeto foi desenvolvido para **praticar conceitos de Programação Orientada a Objetos (POO)** com C# e .NET,  
simulando funcionalidades de diferentes smartphones (Nokia e iPhone) a partir de uma classe abstrata.

A ideia é mostrar na prática **herança, polimorfismo e encapsulamento**, permitindo que cada modelo tenha seu próprio comportamento,
como instalar aplicativos, tirar fotos e usar recursos específicos (ex: FaceID no iPhone).


---


## 📂 Estrutura do Projeto

```
dotnet-cli-abstracao-smartphone/DesafioAbstracao/
├── Domain/
│ ├── Entities/
│ │ ├── Smartphone.cs
│ │ ├── Nokia.cs
│ │ └── Iphone.cs
│ └── Enums/
│ └── SistemaOperacional.cs
├── Tests/
│ ├── NokiaTest.cs
│ └── IphoneTest.cs
└── Program.cs
```

> O ponto de entrada é o **Program.cs**, onde você pode escolher executar os testes de cada smartphone.


---


## 🛠️ Funcionalidades

- [x] Classe abstrata `Smartphone`
  - [x] Definição de propriedades (`Número`, `Modelo`, `IMEI`, `SistemaOperacional`, `VersãoSO`, `Armazenamento`, `Bateria`)
  - [x] Métodos básicos (`Ligar`, `Desligar`, `ReceberLigacao`, `CarregarBateria`)
  - [x] Método abstrato `InstalarAplicativo`

- [x] Classe `Nokia`
  - [x] Implementa instalação de aplicativos pelo **Nokia Store**
  - [x] Método adicional `TirarFoto`

- [x] Classe `Iphone`
  - [x] Implementa instalação de aplicativos pela **App Store**
  - [x] Método adicional `UsarFaceID`

- [x] Testes de funcionalidades
  - [x] Cenários de sucesso e falha (sem espaço, celular desligado, etc.)
  - [x] Métodos auxiliares para instanciar os objetos com diferentes configurações


---


## ⚙️ Tecnologias Utilizadas

- **.NET SDK 9.0:** plataforma utilizada para compilar e executar o projeto.  
- **C#:** linguagem de programação.  
- **Rider:** IDE principal usada no desenvolvimento.  


---


## 🧪 Como Executar

Clone o repositório e entre na pasta do projeto:

```bash
git clone git@github.com:wastecoder/dotnet-cli-abstracao-smartphone.git
cd dotnet-cli-abstracao-smartphone
dotnet build
dotnet run
```


---


## 📈 Próximos Passos

- Adicionar um **menu em CLI** para interação com o usuário
- Implementar **lista de aplicativos** instalados em cada celular
- Simular **uso de memória** de forma mais detalhada
- Adicionar **testes automatizados** com frameworks (xUnit ou NUnit)
