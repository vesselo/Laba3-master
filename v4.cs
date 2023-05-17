using IronXL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba3_TP
{
    public class v4 : IGraph
    {
        static WorkBook bookExcel;
        static WorkSheet sheetExcel;

        public List<int> years { get; set; } = new List<int>();
        public List<float> data { get; set; } = new List<float>();
        public List<float> percentChanges { get; set; } = new List<float>();

        public v4()
        {
            v4.SetSource();
            this.SetData();
        }

        public static void SetSource()
        {
            string path = Environment.CurrentDirectory + "\\VVP.xlsx";
            bookExcel = new WorkBook(path);
            sheetExcel = bookExcel.WorkSheets.First();
        }

        public void SetData()
        {
            var rows = sheetExcel.Rows;
            foreach (var row in rows.Skip(1))
            {
                string[] temp = row.Take(2).Select(x => x.Value.ToString()).ToArray();
                years.Add(int.Parse(temp[0]));
                data.Add(float.Parse(temp[1]));
            }

            years.Reverse();
            data.Reverse();

            //percentChanges.Add(0);
            for (int i = 1; i < data.Count; i++)
                percentChanges.Add((data[i] - data[i - 1]) / data[i - 1] * 100);
        }
    }
}