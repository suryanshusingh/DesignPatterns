using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template2
{
    class TemplateClient
    {
        public static void TemplateDPStartup()
        {
            var documentDataMiner = new DocumentDataMiner();
            documentDataMiner.MineData();

            var pdfDataMiner = new PDFDataMiner();
            pdfDataMiner.MineData();

            var csvDataMiner = new CSVDataMiner();
            csvDataMiner.MineData();

            Console.Read();
        }
    }
}
