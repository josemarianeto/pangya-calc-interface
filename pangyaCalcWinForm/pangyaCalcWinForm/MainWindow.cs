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

    public partial class MainWindow : Form
    {

        public XLWorkbook wb = new XLWorkbook("276SR-Braba.xlsm");

        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void Campos()
        {
            var p = wb.Worksheet(1);
            var d = wb.Worksheet("Dados");
            //Tabela 1 Distancia a Altura em Ordem 
            txtDist.Text =  p.Cell("B1").Value.ToString();
            txtAltura.Text = p.Cell("B2").Value.ToString();
            txtVento.Text = p.Cell("B3").Value.ToString();
            txtAngulo.Text = Math.Round(float.Parse(p.Cell("B4").Value.ToString()), 2).ToString();
            txtSlope.Text = Math.Round(float.Parse(p.Cell("B5").Value.ToString()), 2).ToString();
            txtTerreno.Text = p.Cell("B6").Value.ToString();
           //Fim Tabela 1


            //Tipo de Tacada 
            lbTacada.Text = p.Cell("D1").Value.ToString();
            decimal mathaim455 = Math.Round(decimal.Parse(p.Cell("E2").Value.ToString()));
            txtAim475.Text = Math.Round(float.Parse(p.Cell("E2").Value.ToString()), 2).ToString();

            txtAim4.Text = Math.Round(float.Parse(p.Cell("E3").Value.ToString()), 2).ToString();
            txtPercent.Text = Math.Round(float.Parse(p.Cell("E4").Value.ToString()), 2).ToString();
            txtPB.Text = Math.Round(float.Parse(p.Cell("E5").Value.ToString()), 2).ToString();
            txtCalliper.Text = Math.Round(float.Parse(p.Cell("E6").Value.ToString()), 2).ToString();
            txtSpin.Text = Math.Round(float.Parse(p.Cell("E7").Value.ToString())).ToString();
            tipoTacada.SelectedIndex = Int32.Parse(d.Cell("I35").Value.ToString()) - 1;
            //Fim Tipo Tacada

            //Quebras s4 e s8
            txtQuebrasS4.Text = p.Cell("E17").Value.ToString();
            txtQuebrasS8.Text = p.Cell("E18").Value.ToString();
            if (p.Cell("E16").Value.ToString() == "4")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            cbResolucao.SelectedIndex = Int32.Parse(d.Cell("G8").Value.ToString()) - 1;
            // FIM

            //TABELA DE ANGULOS
            txtRangulo.Text = Math.Round(float.Parse(p.Cell("A9").Value.ToString()),2).ToString();
            rbLup.Text = Math.Round(float.Parse(d.Cell("B27").Value.ToString()), 2).ToString();
            rbLdown.Text = Math.Round(float.Parse(d.Cell("B29").Value.ToString()), 2).ToString();
            rbRup.Text = Math.Round(float.Parse(d.Cell("C27").Value.ToString()), 2).ToString();
            rbRdown.Text = Math.Round(float.Parse(d.Cell("C29").Value.ToString()), 2).ToString();
            //


            txtQuebraPX.Text = Math.Round(float.Parse(p.Cell("B17").Value.ToString()), 2).ToString();
            txtQuebraAngulo.Text = Math.Round(float.Parse(p.Cell("B18").Value.ToString()), 2).ToString();
            txtQuebra.Text = Math.Round(float.Parse(p.Cell("B19").Value.ToString()), 9).ToString();
        }
        public void formata()
        {
            this.Text = 0.ToString();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
            Campos();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void txtDist_Changed(object sender, EventArgs e)
        {
            var p = wb.Worksheet(1);
            
            if(txtDist.Text == "")
            {
                txtDist.Text = "1";
                p.Cell("B1").Value = txtDist.Text;
                Campos();
            }
            else
            {
                p.Cell("B1").Value = txtDist.Text;
                Campos();
            }
            
            
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            var d = wb.Worksheet("Dados");
            if (rbRup.Checked)
            {
                d.Cell("B30").Value = 2;
                rbRup.Text = d.Cell("C29").Value.ToString();
                Campos();
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            var p = wb.Worksheet(1);
            if (txtAltura.Text == "")
            {
                txtAltura.Text = "0";
                p.Cell("B2").Value = txtAltura.Text;
                Campos();
            }
            else
            {
                p.Cell("B2").Value = txtAltura.Text;
                Campos();
            }
        }

        private void txtVento_TextChanged(object sender, EventArgs e)
        {
            var p = wb.Worksheet(1);
            if (txtVento.Text == "")
            {
                txtVento.Text = "0";
                p.Cell("B3").Value = txtVento.Text;
                Campos();
            }
            else
            {
                p.Cell("B3").Value = txtVento.Text;
                Campos();
            }
        }

        private void txtSlope_TextChanged(object sender, EventArgs e)
        {
            var p = wb.Worksheet(1);
            if (txtSlope.Text == "")
            {
                txtSlope.Text = "0";
                p.Cell("B5").Value = txtSlope.Text;
                Campos();
            }
            else
            {
                p.Cell("B5").Value = txtSlope.Text;
                Campos();
            }
        }

        private void txtTerreno_TextChanged(object sender, EventArgs e)
        {
            var p = wb.Worksheet(1);
            if (txtTerreno.Text == "")
            {
                txtTerreno.Text = "1";
                p.Cell("B6").Value = txtTerreno.Text;
                Campos();
            }
            else
            {
                p.Cell("B6").Value = txtTerreno.Text;
                Campos();
            }
        }

        private void tipoTacada_SelectedIndexChanged(object sender, EventArgs e)
        {
            var p = wb.Worksheet("Dados");
            if (tipoTacada.SelectedIndex == 0)
            {
                p.Cell("I35").Value = 1;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 1)
            {
                p.Cell("I35").Value = 2;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 2)
            {
                p.Cell("I35").Value = 3;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 3)
            {
                p.Cell("I35").Value = 4;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 4)
            {
                p.Cell("I35").Value = 5;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 5)
            {
                p.Cell("I35").Value = 6;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 6)
            {
                p.Cell("I35").Value = 7;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 7)
            {
                p.Cell("I35").Value = 8;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 8)
            {
                p.Cell("I35").Value = 9;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 9)
            {
                p.Cell("I35").Value = 10;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 10)
            {
                p.Cell("I35").Value = 11;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 11)
            {
                p.Cell("I35").Value = 12;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 12)
            {
                p.Cell("I35").Value = 13;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 13)
            {
                p.Cell("I35").Value = 14;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 14)
            {
                p.Cell("I35").Value = 15;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 15)
            {
                p.Cell("I35").Value = 16;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 16)
            {
                p.Cell("I35").Value = 16;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 17)
            {
                p.Cell("I35").Value = 16;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 18)
            {
                p.Cell("I35").Value = 17;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 19)
            {
                p.Cell("I35").Value = 18;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 20)
            {
                p.Cell("I35").Value = 19;
                Campos();
            }
            if (tipoTacada.SelectedIndex == 21)
            {
                p.Cell("I35").Value = 20;
                Campos();
            }
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var p = wb.Worksheet(1);
            if (radioButton1.Checked)
            {
                p.Cell("E16").Value = 4;
                Campos();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var p = wb.Worksheet(1);
            if (radioButton2.Checked)
            {
                p.Cell("E16").Value = 8;
                Campos();
            }
        }

        private void cbResolucao_SelectedIndexChanged(object sender, EventArgs e)
        {
            var D = wb.Worksheet("Dados");
            if (cbResolucao.SelectedIndex == 0)
            {
                D.Cell("G8").Value = 1;
                Campos();
            }
            if (cbResolucao.SelectedIndex == 1)
            {
                D.Cell("G8").Value = 2;
                Campos();
            }
            if (cbResolucao.SelectedIndex == 2)
            {
                D.Cell("G8").Value = 3;
                Campos();
            }
            if (cbResolucao.SelectedIndex == 3)
            {
                D.Cell("G8").Value = 4;
                Campos();
            }
        }

        private void rbLup_CheckedChanged(object sender, EventArgs e)
        {
            var d = wb.Worksheet("Dados");
            if (rbLup.Checked)
            {
                d.Cell("B30").Value = 1;
                rbLup.Text =  d.Cell("B27").Value.ToString();
                Campos();
            }
        }

        private void rbLdown_CheckedChanged(object sender, EventArgs e)
        {
            var d = wb.Worksheet("Dados");
            if (rbLdown.Checked)
            {
                d.Cell("B30").Value = 3;
                rbLdown.Text = d.Cell("B29").Value.ToString();
                Campos();
            }
        }

        private void rbRdown_CheckedChanged(object sender, EventArgs e)
        {
            var d = wb.Worksheet("Dados");
            if (rbRdown.Checked)
            {
                d.Cell("B30").Value = 4;
                rbRdown.Text = d.Cell("C29").Value.ToString();
                Campos();
            }
        }

        private void txtRangulo_TextChanged(object sender, EventArgs e)
        {
            var p = wb.Worksheet(1);
            if (txtRangulo.Text == "")
            {
                txtRangulo.Text = "0";
                p.Cell("A9").Value = txtRangulo.Text;
                Campos();
            }
            else
            {
                p.Cell("A9").Value = txtRangulo.Text;
                Campos();
            }
        }

        private void txtQuebraPX_Leave(object sender, EventArgs e)
        {
            var p = wb.Worksheet(1);
            if (txtQuebraPX.Text == "")
            {
                txtQuebraPX.Text = "0";
                p.Cell("B17").Value = txtQuebraPX.Text;
                Campos();
            }
            else
            {
                p.Cell("B17").Value = txtQuebraPX.Text;
                Campos();
            }
        }

        private void txtQuebra_Leave(object sender, EventArgs e)
        {
            var p = wb.Worksheet(1);
            if (txtQuebra.Text == "")
            {
                txtQuebra.Text = "0";
                p.Cell("B18").Value = txtQuebra.Text;
                Campos();
            }
            else
            {
                p.Cell("B18").Value = txtQuebra.Text;
                Campos();
            }
        }

        private void txtQuebraAngulo_Leave(object sender, EventArgs e)
        {
            var p = wb.Worksheet(1);
            if (txtQuebraAngulo.Text == "")
            {
                txtQuebraAngulo.Text = "0";
                p.Cell("B19").Value = txtQuebraAngulo.Text;
                Campos();
            }
            else
            {
                p.Cell("B19").Value = txtQuebraAngulo.Text;
                Campos();
            }
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            var p = wb.Worksheet(1);
            p.Cell("B19").Value = 0;
            p.Cell("B18").Value = 0;
            p.Cell("B17").Value = 0;
            Campos();
        }
    }
}
