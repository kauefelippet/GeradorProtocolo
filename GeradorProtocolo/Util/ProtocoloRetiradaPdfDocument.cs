using System.ComponentModel;
using GeradorProtocolo.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using IContainer = QuestPDF.Infrastructure.IContainer;

namespace GeradorProtocolo.Util
{
    public class ProtocoloRetiradaPdfDocument : IDocument
    {
        private readonly Protocolo protocolo;

        public ProtocoloRetiradaPdfDocument(Protocolo protocolo)
        {
            this.protocolo = protocolo;
        }

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(1, Unit.Centimetre);
                page.Content().Element(ComposeContent);
            });
        }

        void ComposeContent(IContainer container)
        {
            container.Column(column =>
            {
                // Via Cliente
                column.Item().Text("PROTOCOLO DE RETIRADA").AlignCenter().FontSize(12).Bold().FontFamily("Century Gothic");
                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(column =>
                    {
                        column.Item().Text($"Interessado: {protocolo.Requerente}  -  {protocolo.CpfCnpj}").FontSize(10).FontFamily("Century Gothic");
                        if (protocolo.IdProvisorio.HasValue) column.Item().Text($"Recibo Provisório nº {protocolo.IdProvisorio}").FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Pagamento Prévio: {protocolo.Total:C}").FontSize(10).FontFamily("Century Gothic");
                    });

                    row.RelativeItem().Column(column =>
                    {
                        column.Item().Text($"Atendente: {protocolo.Atendente}").AlignRight().FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Solicitação: {DateTime.Now:dd/MM/yyyy HH:mm}").AlignRight().FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Retirada: {protocolo.Retirada:dd/MM/yyyy} a partir das {protocolo.HorarioRetirada:HH:mm}").AlignRight().FontSize(10).Bold().FontFamily("Century Gothic");
                    });

                    column.Item().PaddingVertical(5).Column(column =>
                    {
                        column.Item().Element(ComposeTable);
                    });
                });
                column.Item().Text("");
                column.Item().Text("");
                column.Item().Text("__________________________").AlignCenter().FontSize(12).Bold().FontFamily("Century Gothic");
                column.Item().Text("");

                // Via Cartório

                column.Item().Text("");
                column.Item().Text("");
                column.Item().Text("_________________________________________________________________________________________").AlignCenter().FontSize(12).Bold().FontFamily("Century Gothic");
                column.Item().Text("");
                column.Item().Text("COMPROVANTE DE DEPÓSITO PRÉVIO").AlignCenter().FontSize(12).Bold().FontFamily("Century Gothic");
                column.Item().Row(row =>
                {
                    row.RelativeItem().Column(column =>
                    {
                        column.Item().Text($"Interessado: {protocolo.Requerente}  -  {protocolo.CpfCnpj}").FontSize(10).FontFamily("Century Gothic");
                        if (protocolo.IdProvisorio.HasValue) column.Item().Text($"Recibo Provisório nº {protocolo.IdProvisorio}").FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Pagamento Prévio: {protocolo.Total:C}").FontSize(10).FontFamily("Century Gothic");
                    });

                    row.RelativeItem().Column(column =>
                    {
                        column.Item().Text($"Atendente: {protocolo.Atendente}").AlignRight().FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Solicitação: {DateTime.Now:dd/MM/yyyy HH:mm}").AlignRight().FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Retirada: {protocolo.Retirada:dd/MM/yyyy} a partir das {protocolo.HorarioRetirada:HH:mm}").AlignRight().FontSize(10).Bold().FontFamily("Century Gothic");
                    });

                    column.Item().PaddingVertical(5).Column(column =>
                    {
                        column.Item().Element(ComposeTable);
                    });
                });
                column.Item().Text("");
                column.Item().Text("");
                column.Item().Text("_______________________________________").AlignCenter().FontSize(12).Bold().FontFamily("Century Gothic");
                column.Item().Text("Assinatura do Interessado").AlignCenter().FontSize(12).Bold().FontFamily("Century Gothic");

                // Protocolos para os Livros

                column.Item().Text("");
                column.Item().Text("_________________________________________________________________________________________").AlignCenter().FontSize(12).Bold().FontFamily("Century Gothic");
                column.Item().Text("");

                int Contador = 0;
                int totalProtocoloLivro = protocolo.ProtocoloRetirada.Count(item => item.ProtocoloLivro);
                foreach (var item in protocolo.ProtocoloRetirada)
                {
                    if (item.ProtocoloLivro)
                    {
                        Contador++;

                        column.Item().PreventPageBreak().Row(row =>
                        {
                            row.RelativeItem().Column(column =>
                            {
                                column.Item().Text($"{protocolo.Retirada:dd/MM/yyyy}        Parte(s): {item.NomeParte}").FontSize(12).Bold().FontFamily("Century Gothic");
                                column.Item().Text($"{Contador} de {totalProtocoloLivro}                 {item.TipoRegistro}:  {item.Descricao}  -  Valor: R$ {item.Valor}  -  {protocolo.Atendente}").FontSize(12).Bold().FontFamily("Century Gothic");
                                column.Item().Text($"                              Recibo: {protocolo.Requerente}  -  Solicitação: {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(11).FontFamily("Century Gothic");
                                if (protocolo.IdProvisorio.HasValue) column.Item().Text($"                              Recibo Provisório nº {protocolo.IdProvisorio}").FontSize(11).FontFamily("Century Gothic");
                                if (!string.IsNullOrEmpty(item.CpfParte)) column.Item().Text($"                              CPF(s): {item.CpfParte}").FontSize(11).FontFamily("Century Gothic");
                                column.Item().Text("_________________________________________________________________________________________").AlignCenter().FontSize(12).Bold().FontFamily("Century Gothic");
                            });
                        });
                    }
                }
            });
        }

        void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(30); // Quantidade
                    columns.ConstantColumn(175);   // TipoRegistro
                    columns.RelativeColumn();   // Descrição
                    columns.ConstantColumn(80); // Valor
                });

                table.Header(header =>
                {
                    header.Cell().Element(HeaderStyling).Text("Qtd.");
                    header.Cell().Element(HeaderStyling).Text("Tipo");
                    header.Cell().Element(HeaderStyling).Text("Descrição");
                    header.Cell().Element(HeaderStyling).AlignRight().Text("Valor");

                    static IContainer HeaderStyling(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.SemiBold().FontFamily("Century Gothic")).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                foreach (var item in protocolo.ProtocoloRetirada)
                {
                    table.Cell().Element(CellStyling).Text($"{item.Quantidade}");
                    table.Cell().Element(CellStyling).Text($"{item.TipoRegistro}");
                    table.Cell().Element(CellStyling).Text($"{item.Descricao}");
                    table.Cell().Element(CellStyling).AlignRight().Text($"{item.Total:C}");

                    static IContainer CellStyling(IContainer container)
                    {
                        return container.DefaultTextStyle(x => x.FontSize(10).FontFamily("Century Gothic")).PaddingVertical(0).BorderBottom(1).BorderColor(Colors.Grey.Lighten2);
                    }
                }
            });
        }
    }
}
