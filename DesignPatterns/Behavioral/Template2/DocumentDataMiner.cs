using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template2
{
    class DocumentDataMiner : DataMiner
    {
        public override void CloseFile()
        {
            Console.WriteLine("Document File Close");
        }

        public override void ExtractData()
        {
            Console.WriteLine("Extracting Data from Document");
        }

        public override void OpenFile()
        {
            Console.WriteLine("Opening Document File");
        }

        public override void ParseData()
        {
            Console.WriteLine("Parsing data from Document File");
        }
    }
}
