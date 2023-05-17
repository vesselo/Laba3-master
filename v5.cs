using IronXL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba3_TP
{
    public class v5 : IGraph
    {
        static WorkBook workBook;
        static WorkSheet workSheet;

        public List<int> years { get; set; } = new List<int>();
        public List<float> data { get; set; } = new List<float>();
        public List<float> percentChanges { get; set; } = new List<float>();

        public v5()
        {
            v5.ReadExcel();
            this.SetData();

            years.Reverse();
            data.Reverse();
            for (int i = 1; i < data.Count; i++)
                percentChanges.Add((data[i] - data[i - 1]) / data[i - 1] * 100);
        }
        public static void ReadExcel()
        {
            string path = Environment.CurrentDirectory + "\\Naselenie.xlsx";
            workBook = new WorkBook(path);
            workSheet = workBook.WorkSheets.First();
        }
        public void SetData()
        {
            foreach (var cell in workSheet["A2:A16"])
                years.Add(int.Parse(cell.Text));
            foreach (var cell in workSheet["B2:B16"])
                data.Add(float.Parse(cell.Text));
        }
    }
}