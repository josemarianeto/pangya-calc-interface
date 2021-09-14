using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pangyaCalcWinForm
{
    public partial class windhill : Form
    {
        public XLWorkbook wb = new XLWorkbook("276SR-Braba2.xlsm");
        public windhill()
        {
            InitializeComponent();

            var p = wb.Worksheet(1);
            txtmira1.Text = p.Cell("M2").Value.ToString();
            txtmira2.Text = p.Cell("M3").Value.ToString();
            txtmirar.Text = p.Cell("M4").Value.ToString();
            txtf1.Text = p.Cell("M5").Value.ToString();
            txtf2.Text = p.Cell("M6").Value.ToString();
            txtf3.Text = p.Cell("M7").Value.ToString();
            txtP11.Text = p.Cell("M8").Value.ToString();
            txtP12.Text = p.Cell("N8").Value.ToString();
            txtP21.Text = p.Cell("M9").Value.ToString();
            txtP22.Text = p.Cell("N9").Value.ToString();
        }
    }
}
