using System;
using System.Linq;
using System.Windows.Forms;

namespace Laba3_TP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IGraph gr;

        private void button1_Click(object sender, EventArgs e)
        {
            gr = new v4();
            DrawGraph();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gr = new v5();
            DrawGraph();
        }

        private void DrawGraph()
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisY.Minimum = (int)gr.data.Min() - 2; 
            for (int i = 0; i < 15; i++)
            {
                chart1.Series[0].Points.AddXY(gr.years[i], gr.data[i]);
            }
            for (int j = 0; j < 14; j++)
            {
                chart2.Series[0].Points.AddXY(gr.years[j+1], gr.percentChanges[j]);
            }

        }
    }
}
