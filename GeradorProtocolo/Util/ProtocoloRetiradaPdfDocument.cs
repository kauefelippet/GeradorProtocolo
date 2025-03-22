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
                page.Margin((float)0.6, Unit.Centimetre);
                page.Content().Element(ComposeContent);
            });
        }

        void ComposeContent(IContainer container)
        {
            container.DefaultTextStyle(style => style.FontFamily("Century Gothic")).Column(column =>
            {
                // Via Cliente
                AddHeader(column, "PROTOCOLO DE RETIRADA");
                AddClientInfo(column);
                AddTable(column);
                AddFooter(column, "__________________________");

                // Via Cartório
                column.Item().PaddingTop(45).PaddingBottom(15).LineHorizontal((float)0.5);
                AddHeader(column, "COMPROVANTE DE DEPÓSITO PRÉVIO");
                AddClientInfo(column);
                AddTable(column);
                AddFooter(column, "_______________________________________", "Assinatura do Interessado");

                // Protocolos para os Livros
                column.Item().PaddingTop(15).PaddingBottom(5).LineHorizontal((float)0.5);
                AddProtocolosParaOsLivros(column);
            });
        }

        void AddHeader(ColumnDescriptor column, string title)
        {
            column.Item().Text(title).AlignCenter().FontSize(12).Bold();
        }

        void AddClientInfo(ColumnDescriptor column)
        {
            column.Item().Row(row =>
            {
                row.ConstantItem(370).Column(column =>
                {
                    column.Item().Text(text =>
                    {
                        text.Span("Interessado: ").FontSize(10).Bold();
                        text.Span($"{protocolo.Requerente}  -  {protocolo.CpfCnpj}").FontSize(10);
                    });
                    if (protocolo.IdProvisorio.HasValue)
                        column.Item().Text($"Recibo Provisório nº {protocolo.IdProvisorio}").FontSize(10).Bold();
                    column.Item().Text(text =>
                    {
                        text.Span("Pagamento Prévio: ").FontSize(10).Bold();
                        text.Span($"{protocolo.Total:C}").FontSize(10);
                    });
                });

                row.RelativeItem().Column(column =>
                {
                    column.Item().AlignRight().Text(text =>
                    {
                        text.Span("Atendente: ").FontSize(10).Bold();
                        text.Span(protocolo.Atendente).FontSize(10);
                    });
                    column.Item().AlignRight().Text(text =>
                    {
                        text.Span("Solicitação: ").FontSize(10).Bold();
                        text.Span($"{DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(10);
                    });
                    column.Item().Text($"Retirada: {protocolo.Retirada:dd/MM/yyyy} a partir das {protocolo.HorarioRetirada:HH:mm}").AlignRight().FontSize(10).Bold();
                });
            });
        }

        void AddTable(ColumnDescriptor column)
        {
            column.Item().PaddingVertical(5).Element(ComposeTable);
        }

        void AddFooter(ColumnDescriptor column, string line, string? signature = null)
        {
            column.Item().Text("");
            column.Item().Text("");
            column.Item().Text(line).AlignCenter().FontSize(12).Bold();
            if (signature != null)
            {
                column.Item().Text(signature).AlignCenter().FontSize(12).Bold();
            }
        }

        void AddProtocolosParaOsLivros(ColumnDescriptor column)
        {
            int contador = 0;
            int totalProtocoloLivro = protocolo.ProtocoloRetirada.Count(item => item.ProtocoloLivro);
            foreach (var item in protocolo.ProtocoloRetirada.Where(item => item.ProtocoloLivro))
            {
                contador++;
                column.Item().DefaultTextStyle(style => style.FontSize(12)).PreventPageBreak().Row(row =>
                {
                    row.ConstantItem(50).RotateLeft().Column(column =>
                    {
                        column.Item().Text($"{protocolo.Retirada:dd/MM/yyyy}").AlignCenter().FontSize(12).Bold();
                        column.Item().Text($"{contador} de {totalProtocoloLivro}").AlignCenter().FontSize(12).Bold();
                    });
                    row.RelativeItem().Column(column =>
                    {
                        column.Item().Text(text =>
                        {
                            text.Span("Parte(s): ").FontSize(12).Bold();
                            text.Span(item.NomeParte).FontSize(12);
                        });
                        column.Item().Text(text =>
                        {
                            text.Span($"{item.TipoRegistro}: ").FontSize(12).Bold();
                            text.Span($"{item.Descricao}  -  ").FontSize(12);
                            text.Span("Valor: ").FontSize(12).Bold();
                            text.Span($"{item.Valor:C}  -  {protocolo.Atendente}").FontSize(12);
                        });
                        if (!string.IsNullOrEmpty(item.CpfParte))
                            column.Item().Text(text =>
                            {
                                text.Span("CPF(s): ").FontSize(11).Bold();
                                text.Span(item.CpfParte).FontSize(11);
                            });
                        column.Item().Text(text =>
                        {
                            text.Span("Recibo: ").FontSize(11).Bold();
                            text.Span($"{protocolo.Requerente}  -  ").FontSize(11);
                            text.Span("Solicitação: ").FontSize(11).Bold();
                            text.Span($"{DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(11);
                        });
                        if (protocolo.IdProvisorio.HasValue)
                            column.Item().Text($"Recibo Provisório nº {protocolo.IdProvisorio}").FontSize(11).Bold();
                    });
                });
                column.Item().PaddingVertical(10).LineHorizontal((float)0.5);
            }
        }

        void ComposeTable(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(30); // Quantidade
                    columns.ConstantColumn(175); // TipoRegistro
                    columns.RelativeColumn(); // Descrição
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
