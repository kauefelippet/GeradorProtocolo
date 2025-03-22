using QuestPDF.Infrastructure;

namespace GeradorProtocolo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());

            // Mocking a Protocolo and two Item for debugging

            //BindingList<Item> itens = new();
            //itens.Add(new Item
            //{
            //    TipoRegistro = "CERTIDÃO EM INTEIRO TEOR",
            //    NomeParte = "Cliente da Silva e Silva da Cliente",
            //    Descricao = "Alguma string bem grande L B-12, fls. 11, n 999",
            //    Valor = 45.02,
            //    Quantidade = 2,
            //    ProtocoloLivro = true
            //});
            //itens.Add(new Item
            //{
            //    TipoRegistro = "CERTIDÃO BREVE RELATORIO",
            //    NomeParte = "Outro Cliente e Cliente Outro",
            //    CpfParte = "123.123.123-11 e 333.333.333-33",
            //    Descricao = "L B-13, fls. 12, n 1000",
            //    Valor = 45.02,
            //    Quantidade = 1,
            //    ProtocoloLivro = true
            //});

            //Protocolo protocolo = new Protocolo
            //{
            //    Requerente = "Cliente da Silva",
            //    CpfCnpj = "123.123.123-11",
            //    Atendente = "Kaue",
            //    IdProvisorio = 15,
            //    Retirada = DateOnly.FromDateTime(DateTime.Now),
            //    HorarioRetirada = DateTime.Now,
            //    ProtocoloRetirada = itens
            //};

            //ProtocoloRetiradaPdfDocument document = new(protocolo);
            //document.ShowInCompanion();
        }
    }
}