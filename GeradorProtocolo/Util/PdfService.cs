using QuestPDF.Fluent;


namespace GeradorProtocolo.Util
{
    public class PdfService
    {
        public void GenerateProtocoloRetiradaPdf(ProtocoloRetiradaPdfDocument document, string outputPath)
        {
            document.GeneratePdf(outputPath);
        }

        public void GenerateProtocoloRetiradaPdfAndShow(ProtocoloRetiradaPdfDocument document)
        {
            document.GeneratePdfAndShow();
        }
    }
}
