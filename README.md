# SuperPlan

SuperPlan é uma aplicação web para o gerenciamento de despesas pessoais. A aplicação foi desenvolvida usando Blazor e .NET 7.

## Pré-requisitos

Antes de começar, certifique-se de ter atendido aos seguintes requisitos:

- Você instalou a versão mais recente do .NET 7 SDK. Baixe [aqui](https://dotnet.microsoft.com/download/dotnet/7.0).
- Você instalou o Visual Studio 2022 ou superior. Baixe [aqui](https://visualstudio.microsoft.com/vs/).
- Você tem uma máquina Windows, Linux ou macOS.

## Instalando o SuperPlan

Para instalar o SuperPlan, siga estas etapas:

1. Clone o repositório:

```bash
git clone https://github.com/yourusername/superplan.git
```

2. Navegue até a pasta do projeto:

```bash
cd superplan
```

3. Restaure os pacotes do NuGet:

```bash
dotnet restore
```

## Usando o SuperPlan

Para usar o SuperPlan, siga estas etapas:

1. Compile o projeto:

```bash
dotnet build
```

2. Execute o projeto:

```bash
dotnet run
```

## Configurando a Conexão com o Banco de Dados

Este projeto usa o Secret Manager do .NET Core para armazenar a string de conexão do banco de dados de forma segura. Para configurar a string de conexão em sua máquina local, siga as instruções abaixo:

1. **Instalar a Ferramenta Secret Manager**:

    Se você ainda não instalou a ferramenta Secret Manager, você pode fazer isso usando a linha de comando .NET Core:

    ```bash
    dotnet tool install --global dotnet-user-secrets --version 2.2.0
    ```

2. **Inicializar o Secret Manager para este projeto**:

    Navegue até a pasta do projeto (onde o arquivo .csproj está localizado) e execute o seguinte comando para inicializar o Secret Manager:

    ```bash
    dotnet user-secrets init
    ```

3. **Definir a String de Conexão**:

    Agora você pode definir a string de conexão para o banco de dados. Substitua `YourConnectionString` pelo valor real da string de conexão e execute o seguinte comando:

    ```bash
    dotnet user-secrets set "ConnectionStrings:DefaultConnection" "YourConnectionString"
    ```

Agora, quando você executar o projeto em sua máquina local, ele usará essa string de conexão para se conectar ao banco de dados. Lembre-se de que os segredos do usuário não são criptografados e não devem ser usados em ambientes de produção.

---

Apenas ajuste as instruções de acordo com o que se aplica ao seu projeto e ambiente específicos.
