using System.ComponentModel;
using GeradorProtocolo.Models;
using GeradorProtocolo.Util;
using QuestPDF.Companion;
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


            BindingList<Item> itens = new();
            itens.Add(new Item
            {
                Requerente = "Cliente da Silva",
                CpfCnpj = "123.123.123-11",
                TipoRegistro = "CERTIDÃO EM INTEIRO TEOR",
                NomeParte = "Cliente da Silva e Silva da Cliente",
                Descricao = "Averbação de Retificação L B-12, fls. 11, n 999",
                Valor = 4500.02,
                Quantidade = 2,
                ProtocoloLivro = true
            });
            ProtocoloRetiradaPdfDocument document = new(itens, DateOnly.FromDateTime(DateTime.Now), "Kaue");
            document.ShowInCompanion();
        }
    }
}