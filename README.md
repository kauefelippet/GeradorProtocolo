# Gerador de Protocolos

![C# Badge](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.Net Badge](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

![image](https://github.com/user-attachments/assets/c72cbc78-7a5a-4c4f-9a3e-460081ceab92)

## Overview

The GeradorProtocolo project was created to streamline the process of generating protocols for certificate requests at the Oficial de Registro Civil das Pessoas Naturais e de Interdições e Tutelas da Sede de Itu/SP. Traditionally, this process involved manually filling out several papers and protocols, leading to significant time loss. This project automates the creation of these protocols using the QuestPDF library, allowing for the generation of a PDF document with all the necessary protocols, which can then be printed and signed.

## Features
- **Automated Protocol Generation:** Automatically generate protocols based on user input.
- **PDF Generation:** Utilize the QuestPDF library to create PDF documents.
- **User-Friendly Interface:** Simple and intuitive interface for entering required information.
- **Customizable Fields:** Easily fill in fields.
- **Support for Multiple Items:** Handle multiple items in a single protocol.
- **Protocolo para Livro:** Option to create protocols for registry books.

## Requirements

- **.NET 8.0:** The project was developed using .NET 8.0, so it is necessary to have this version installed on your machine.

## Installation

1. **Download the latest release:** Download the latest release from the project's GitHub page.
2. **Install the .msi file**: Run the .msi file and follow the installation instructions.
3. **Certify you have .NET 8.0 installed:** Make sure you have .NET 8.0 installed on your machine.
4. **Run the application:** Run the application and start generating protocols.

## Usage

1.	**Run the Application:** Start the application from your desktop shortcut.
2.	**Fill in the Fields:** Enter the required information in the provided fields.
3.	**Add Items:** Click the "Adicionar" button to add items to the protocol.
4.	**Generate PDF:** Click the "Gerar" button to generate the PDF document.
5.	**Save and Print:** Save the generated PDF and print it.

## Code Structure

The project is structured as follows:
<pre>
├── .gitattributes
├── .gitignore
├── Gerador de Protocolos
    └── Gerador de Protocolos.vdproj
├── GeradorProtocolo.sln
├── GeradorProtocolo
    ├── GeradorProtocolo.csproj
    ├── Menu.Designer.cs
    ├── Menu.cs
    ├── Menu.resx
    ├── Models
    │   └── Item.cs
    │   └── Protocolo.cs
    ├── Program.cs
    ├── StyleFiles
    │   └── Icon.ico
    └── Util
    │   ├── PdfService.cs
    │   └── ProtocoloRetiradaPdfDocument.cs
└── LICENSE.txt
</pre>

- **Program.cs:** The main entry point for the application.
- **Menu.cs:** The main form where users enter information and generate protocols.
- **Models/Protocolo.cs:** The model representing the protocol.
- **Models/Item.cs:** The model representing an item in the protocol.
- **Util/ProtocoloRetiradaPdfDocument.cs:** The class responsible for creating the PDF document.
- **Util/PdfService.cs:** The service class for generating the PDF document.

## License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

---

# Gerador de Protocolos

![Badge C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![Badge .Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

![image](https://github.com/user-attachments/assets/c72cbc78-7a5a-4c4f-9a3e-460081ceab92)

## Visão Geral

O projeto GeradorProtocolo foi criado para otimizar o processo de geração de protocolos para solicitações de certidões no Oficial de Registro Civil das Pessoas Naturais e de Interdições e Tutelas da Sede de Itu/SP. Tradicionalmente, esse processo envolvia o preenchimento manual de diversos papéis e protocolos, levando a uma perda significativa de tempo. Este projeto automatiza a criação desses protocolos usando a biblioteca QuestPDF, permitindo a geração de um documento PDF com todos os protocolos necessários, que podem então ser impressos e assinados.

## Funcionalidades
- **Geração Automática de Protocolos:** Gere automaticamente protocolos com base nas informações inseridas pelo usuário.
- **Geração de PDF:** Utiliza a biblioteca QuestPDF para criar documentos PDF.
- **Interface Amigável:** Interface simples e intuitiva para inserir as informações necessárias.
- **Campos Personalizáveis:** Preencha os campos facilmente.
- **Suporte para Múltiplos Itens:** Lide com múltiplos itens em um único protocolo.
- **Protocolo para Livro:** Opção para criar protocolos para os livros de registros.

## Requisitos

- **.NET 8.0:** O projeto foi desenvolvido utilizando .NET 8.0, portanto é necessário ter esta versão instalada em sua máquina.

## Instalação

1. **Baixe a versão mais recente:** Baixe a versão mais recente da página do projeto no GitHub.
2. **Instale o arquivo .msi:** Execute o arquivo .msi e siga as instruções de instalação.
3. **Certifique-se de ter o .NET 8.0 instalado:** Verifique se você tem o .NET 8.0 instalado em sua máquina.
4. **Execute a aplicação:** Execute a aplicação e comece a gerar os protocolos.

## Utilização

1.  **Execute a Aplicação:** Inicie a aplicação pelo atalho em sua área de trabalho.
2.  **Preencha os Campos:** Insira as informações necessárias nos campos fornecidos.
3.  **Adicione Itens:** Clique no botão "Adicionar" para adicionar itens ao protocolo.
4.  **Gere o PDF:** Clique no botão "Gerar" para gerar o documento PDF.
5.  **Salve e Imprima:** Salve o PDF gerado e imprima-o.

## Estrutura do Código

A estrutura do projeto é a seguinte:
<pre>
├── .gitattributes
├── .gitignore
├── Gerador de Protocolos
    └── Gerador de Protocolos.vdproj
├── GeradorProtocolo.sln
├── GeradorProtocolo
    ├── GeradorProtocolo.csproj
    ├── Menu.Designer.cs
    ├── Menu.cs
    ├── Menu.resx
    ├── Models
    │   └── Item.cs
    │   └── Protocolo.cs
    ├── Program.cs
    ├── StyleFiles
    │   └── Icon.ico
    └── Util
    │   ├── PdfService.cs
    │   └── ProtocoloRetiradaPdfDocument.cs
└── LICENSE.txt
</pre>

- **Program.cs:** O ponto de entrada principal da aplicação.
- **Menu.cs:** O formulário principal onde os usuários inserem as informações e geram os protocolos.
- **Models/Protocolo.cs:** O modelo que representa o protocolo.
- **Models/Item.cs:** O modelo que representa um item no protocolo.
- **Util/ProtocoloRetiradaPdfDocument.cs:** A classe responsável por criar o documento PDF.
- **Util/PdfService.cs:** A classe de serviço para gerar o documento PDF.

## Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE.txt](LICENSE.txt) para detalhes.
