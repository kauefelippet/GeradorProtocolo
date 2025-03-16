using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;


namespace GeradorProtocolo.Util
{
    public class PdfService
    {
        public void GenerateProtocoloRetiradaPdf(ProtocoloRetiradaPdfDocument document, string outputPath)
        {
            document.GeneratePdf(outputPath);
        }
    }
}
