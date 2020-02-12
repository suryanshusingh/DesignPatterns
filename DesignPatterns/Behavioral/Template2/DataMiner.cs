using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Template2
{
    public abstract class DataMiner
    {
        public abstract void OpenFile();
        public abstract void ExtractData();
        public abstract void ParseData();
        public void AnalyzeData()
        {
            Console.WriteLine($"Analyzing Data for {this.GetType().Name}!!");
        }
        public void SendReport()
        {
            Console.WriteLine($"Sending Report for {this.GetType().Name}!!");
        }
        public abstract void CloseFile();

        public void MineData()
        {
            OpenFile();
            ExtractData();
            ParseData();
            AnalyzeData();
            SendReport();
            CloseFile();
        }
        
    }
}
