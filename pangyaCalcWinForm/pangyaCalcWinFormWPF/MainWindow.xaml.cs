
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pangyaCalcWinFormWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public ExcelPackage wb = new ExcelPackage(new FileInfo("276SR-Braba.xlsm"));
        
        public MainWindow()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var p = wb.Workbook.Worksheets[1];
            Campos();
        }
        public void Campos()
        {
            var p = wb.Workbook.Worksheets[1];
            txtDist.Text = p.Cells["B1"].Value.ToString();
            txtAltura.Text = p.Cells["B2"].Value.ToString();
            
            txtAim475.Text = Math.Round(float.Parse(p.Cells["E2"].Value.ToString()), 2).ToString();
            
            
        }
        private void txtDist_TextChanged(object sender, TextChangedEventArgs e)
        {
            var p = wb.Workbook.Worksheets[1];
            txtDist.Text = p.Cells["B1"].Value.ToString();
            Campos();
        }
    }
}
