using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template2
{
    class PDFDataMiner : DataMiner
    {
        public override void CloseFile()
        {
            Console.WriteLine("PDF File Close");
        }

        public override void ExtractData()
        {
            Console.WriteLine("Extracting Data from PDF");
        }

        public override void OpenFile()
        {
            Console.WriteLine("Opening PDF File");
        }

        public override void ParseData()
        {
            Console.WriteLine("Parsing data from PDF File");
        }
    }
}
