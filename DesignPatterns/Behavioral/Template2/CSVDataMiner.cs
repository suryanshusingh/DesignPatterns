using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template2
{
    class CSVDataMiner : DataMiner
    {
        public override void CloseFile()
        {
            Console.WriteLine("CSV File Close");
        }

        public override void ExtractData()
        {
            Console.WriteLine("Extracting Data from CSV");
        }

        public override void OpenFile()
        {
            Console.WriteLine("Opening CSV File");
        }

        public override void ParseData()
        {
            Console.WriteLine("Parsing data from CSV File");
        }
    }
}
