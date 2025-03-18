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
        private readonly BindingList<Item> Itens;
        private readonly DateOnly Retirada;
        private readonly string Atendente;
        private readonly int? IdProvisorio;
        private double Total;

        public ProtocoloRetiradaPdfDocument(BindingList<Item> itens, DateOnly retirada, string atendente)
        {
            this.Itens = itens;
            this.Retirada = retirada;
            this.Atendente = atendente;
            foreach (var item in this.Itens)
            {
                Total += item.Total;
            }
        }

        public ProtocoloRetiradaPdfDocument(BindingList<Item> itens, DateOnly retirada, string atendente, int idReciboProvisorio)
        {
            this.Itens = itens;
            this.Retirada = retirada;
            this.Atendente = atendente;
            this.IdProvisorio = idReciboProvisorio;
            foreach (var item in this.Itens)
            {
                Total += item.Total;
            }
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
                        column.Item().Text($"Interessado: {Itens[0].Requerente}  -  {Itens[0].CpfCnpj}").FontSize(10).FontFamily("Century Gothic");
                        if (IdProvisorio.HasValue) column.Item().Text($"Recibo Provisório nº {IdProvisorio}").FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Pagamento Prévio: {Total:C}").FontSize(10).FontFamily("Century Gothic");
                    });

                    row.RelativeItem().Column(column =>
                    {
                        column.Item().Text($"Atendente: {Atendente}").AlignRight().FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Solicitação: {DateTime.Now:dd/MM/yyyy HH:mm}").AlignRight().FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Retirada: {Retirada:dd/MM/yyyy} a partir das 14:00").AlignRight().FontSize(10).Bold().FontFamily("Century Gothic");
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
                        column.Item().Text($"Interessado: {Itens[0].Requerente}  -  {Itens[0].CpfCnpj}").FontSize(10).FontFamily("Century Gothic");
                        if (IdProvisorio.HasValue) column.Item().Text($"Recibo Provisório nº {IdProvisorio}").FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Pagamento Prévio: {Total:C}").FontSize(10).FontFamily("Century Gothic");
                    });

                    row.RelativeItem().Column(column =>
                    {
                        column.Item().Text($"Atendente: {Atendente}").AlignRight().FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Solicitação: {DateTime.Now:dd/MM/yyyy HH:mm}").AlignRight().FontSize(10).FontFamily("Century Gothic");
                        column.Item().Text($"Retirada: {Retirada:dd/MM/yyyy} a partir das 14:00").AlignRight().FontSize(10).Bold().FontFamily("Century Gothic");
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
                int totalProtocoloLivro = Itens.Count(item => item.ProtocoloLivro);
                foreach (var item in Itens)
                {
                    if (item.ProtocoloLivro)
                    {
                        Contador++;

                        column.Item().PreventPageBreak().Row(row =>
                        {
                            row.RelativeItem().Column(column =>
                            {
                                column.Item().Text($"{Retirada:dd/MM/yyyy}        Parte(s): {item.NomeParte}").FontSize(12).Bold().FontFamily("Century Gothic");
                                column.Item().Text($"{Contador} de {totalProtocoloLivro}                 {item.TipoRegistro}:  {item.Descricao}  -  Valor: R$ {item.Valor}  -  {Atendente}").FontSize(12).Bold().FontFamily("Century Gothic");
                                column.Item().Text($"                              Recibo: {item.Requerente}  -  Solicitação: {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(11).FontFamily("Century Gothic");
                                if (IdProvisorio.HasValue) column.Item().Text($"                              Recibo Provisório nº {IdProvisorio}").FontSize(11).FontFamily("Century Gothic");
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

                foreach (var item in Itens)
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
