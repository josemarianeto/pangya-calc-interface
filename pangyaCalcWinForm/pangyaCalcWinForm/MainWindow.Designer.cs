
namespace pangyaCalcWinForm
{
    partial class MainWindow
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTerreno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSlope = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tipoTacada = new System.Windows.Forms.ComboBox();
            this.txtSpin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCalliper = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAim4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAim475 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTacada = new System.Windows.Forms.Label();
            this.cbResolucao = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnZerar = new System.Windows.Forms.Button();
            this.txtQuebra = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtQuebraAngulo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtQuebraPX = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbRup = new System.Windows.Forms.RadioButton();
            this.rbLdown = new System.Windows.Forms.RadioButton();
            this.rbRdown = new System.Windows.Forms.RadioButton();
            this.rbLup = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtRangulo = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtHoleP = new System.Windows.Forms.TextBox();
            this.cbHole = new System.Windows.Forms.ComboBox();
            this.btnHole1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnWindHill = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDist
            // 
            this.txtDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDist.Location = new System.Drawing.Point(6, 46);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(85, 26);
            this.txtDist.TabIndex = 0;
            this.txtDist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oNovoTab);
            this.txtDist.Leave += new System.EventHandler(this.txtDist_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distancia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTerreno);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSlope);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAngulo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDist);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dados Hole";
            // 
            // txtTerreno
            // 
            this.txtTerreno.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTerreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerreno.Location = new System.Drawing.Point(113, 160);
            this.txtTerreno.Name = "txtTerreno";
            this.txtTerreno.Size = new System.Drawing.Size(85, 26);
            this.txtTerreno.TabIndex = 10;
            this.txtTerreno.TextChanged += new System.EventHandler(this.txtTerreno_TextChanged_1);
            this.txtTerreno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oNovoTab);
            this.txtTerreno.Leave += new System.EventHandler(this.txtTerreno_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Terreno";
            // 
            // txtSlope
            // 
            this.txtSlope.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSlope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlope.Location = new System.Drawing.Point(113, 102);
            this.txtSlope.Name = "txtSlope";
            this.txtSlope.Size = new System.Drawing.Size(85, 26);
            this.txtSlope.TabIndex = 8;
            this.txtSlope.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oNovoTab);
            this.txtSlope.Leave += new System.EventHandler(this.txtSlope_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Slope";
            // 
            // txtAngulo
            // 
            this.txtAngulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAngulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngulo.Location = new System.Drawing.Point(113, 46);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.ReadOnly = true;
            this.txtAngulo.Size = new System.Drawing.Size(85, 26);
            this.txtAngulo.TabIndex = 6;
            this.txtAngulo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Angulo";
            // 
            // txtVento
            // 
            this.txtVento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVento.Location = new System.Drawing.Point(6, 160);
            this.txtVento.Name = "txtVento";
            this.txtVento.Size = new System.Drawing.Size(85, 26);
            this.txtVento.TabIndex = 4;
            this.txtVento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oNovoTab);
            this.txtVento.Leave += new System.EventHandler(this.txtVento_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vento";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(6, 102);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(85, 26);
            this.txtAltura.TabIndex = 2;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oNovoTab);
            this.txtAltura.Leave += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tipoTacada);
            this.groupBox2.Controls.Add(this.txtSpin);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtCalliper);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPercent);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAim4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtAim475);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbTacada);
            this.groupBox2.Location = new System.Drawing.Point(222, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 227);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tipoTacada
            // 
            this.tipoTacada.FormattingEnabled = true;
            this.tipoTacada.Items.AddRange(new object[] {
            "Dunk 1w 11s\t",
            "Dunk 1w 30s\t",
            "Dunk 1w 1PS 30s\t",
            "Dunk 1w 2PS 30s\t",
            "Dunk 2w 11s\t",
            "Dunk 2w 30s\t",
            "Dunk 2w 1PS 30s\t",
            "Dunk 3w 11s\t",
            "Dunk 3w 30s\t",
            "Toma 1w\t",
            "Toma 2w\t",
            "Toma 3w\t",
            "Toma 1w 30s\t",
            "Spike 1w 7s\t",
            "Spike 1w 30s\t",
            "Spike 1w 2PS 30s\t",
            "1w D.Curve 11c\t",
            "1wD.Curve -11\t",
            "3w D.Curve 7\t",
            "3w D.Curve -7\t",
            "Dunk 2i 180Y 30s\t"});
            this.tipoTacada.Location = new System.Drawing.Point(6, 200);
            this.tipoTacada.Name = "tipoTacada";
            this.tipoTacada.Size = new System.Drawing.Size(192, 21);
            this.tipoTacada.TabIndex = 4;
            this.tipoTacada.SelectedIndexChanged += new System.EventHandler(this.tipoTacada_SelectedIndexChanged);
            this.tipoTacada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oNovoTab);
            // 
            // txtSpin
            // 
            this.txtSpin.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpin.Location = new System.Drawing.Point(113, 160);
            this.txtSpin.Name = "txtSpin";
            this.txtSpin.Size = new System.Drawing.Size(85, 26);
            this.txtSpin.TabIndex = 24;
            this.txtSpin.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(109, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Spin";
            // 
            // txtCalliper
            // 
            this.txtCalliper.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCalliper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalliper.Location = new System.Drawing.Point(113, 102);
            this.txtCalliper.Name = "txtCalliper";
            this.txtCalliper.Size = new System.Drawing.Size(85, 26);
            this.txtCalliper.TabIndex = 22;
            this.txtCalliper.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(109, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Calliper";
            // 
            // txtPB
            // 
            this.txtPB.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPB.Location = new System.Drawing.Point(113, 46);
            this.txtPB.Name = "txtPB";
            this.txtPB.Size = new System.Drawing.Size(85, 26);
            this.txtPB.TabIndex = 20;
            this.txtPB.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(109, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "PB";
            // 
            // txtPercent
            // 
            this.txtPercent.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercent.Location = new System.Drawing.Point(6, 160);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(85, 26);
            this.txtPercent.TabIndex = 18;
            this.txtPercent.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "%";
            // 
            // txtAim4
            // 
            this.txtAim4.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAim4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAim4.Location = new System.Drawing.Point(6, 102);
            this.txtAim4.Name = "txtAim4";
            this.txtAim4.Size = new System.Drawing.Size(85, 26);
            this.txtAim4.TabIndex = 16;
            this.txtAim4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Aim/4";
            // 
            // txtAim475
            // 
            this.txtAim475.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAim475.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAim475.Location = new System.Drawing.Point(6, 46);
            this.txtAim475.Name = "txtAim475";
            this.txtAim475.Size = new System.Drawing.Size(85, 26);
            this.txtAim475.TabIndex = 14;
            this.txtAim475.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Aim/4,75";
            // 
            // lbTacada
            // 
            this.lbTacada.AutoSize = true;
            this.lbTacada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTacada.Location = new System.Drawing.Point(60, 0);
            this.lbTacada.Name = "lbTacada";
            this.lbTacada.Size = new System.Drawing.Size(24, 17);
            this.lbTacada.TabIndex = 13;
            this.lbTacada.Text = "??";
            // 
            // cbResolucao
            // 
            this.cbResolucao.FormattingEnabled = true;
            this.cbResolucao.Items.AddRange(new object[] {
            "800x600 Big PB",
            "1024x768 Big PB",
            "800x600 Small PB",
            "1024x768 Small PB"});
            this.cbResolucao.Location = new System.Drawing.Point(15, 19);
            this.cbResolucao.Name = "cbResolucao";
            this.cbResolucao.Size = new System.Drawing.Size(173, 21);
            this.cbResolucao.TabIndex = 26;
            this.cbResolucao.TabStop = false;
            this.cbResolucao.SelectedIndexChanged += new System.EventHandler(this.cbResolucao_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWindHill);
            this.groupBox3.Controls.Add(this.btnRight);
            this.groupBox3.Controls.Add(this.btnLeft);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtRangulo);
            this.groupBox3.Location = new System.Drawing.Point(12, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 215);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(319, 52);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 35;
            this.btnRight.TabStop = false;
            this.btnRight.Text = "<<<";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(188, 52);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 34;
            this.btnLeft.TabStop = false;
            this.btnLeft.Text = ">>>";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnZerar);
            this.groupBox7.Controls.Add(this.txtQuebra);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.txtQuebraAngulo);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.txtQuebraPX);
            this.groupBox7.Location = new System.Drawing.Point(172, 84);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(236, 125);
            this.groupBox7.TabIndex = 29;
            this.groupBox7.TabStop = false;
            // 
            // btnZerar
            // 
            this.btnZerar.Location = new System.Drawing.Point(140, 86);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(75, 23);
            this.btnZerar.TabIndex = 98;
            this.btnZerar.TabStop = false;
            this.btnZerar.Text = "Zerar";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // txtQuebra
            // 
            this.txtQuebra.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtQuebra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuebra.Location = new System.Drawing.Point(8, 83);
            this.txtQuebra.Name = "txtQuebra";
            this.txtQuebra.Size = new System.Drawing.Size(85, 26);
            this.txtQuebra.TabIndex = 30;
            this.txtQuebra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oNovoTab);
            this.txtQuebra.Leave += new System.EventHandler(this.txtQuebra_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 20);
            this.label20.TabIndex = 31;
            this.label20.Text = "Quebra";
            // 
            // txtQuebraAngulo
            // 
            this.txtQuebraAngulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtQuebraAngulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuebraAngulo.Location = new System.Drawing.Point(140, 31);
            this.txtQuebraAngulo.Name = "txtQuebraAngulo";
            this.txtQuebraAngulo.Size = new System.Drawing.Size(85, 26);
            this.txtQuebraAngulo.TabIndex = 28;
            this.txtQuebraAngulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oNovoTab);
            this.txtQuebraAngulo.Leave += new System.EventHandler(this.txtQuebraAngulo_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(156, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Angulo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(35, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 20);
            this.label18.TabIndex = 27;
            this.label18.Text = "PX";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtQuebraPX
            // 
            this.txtQuebraPX.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtQuebraPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuebraPX.Location = new System.Drawing.Point(8, 31);
            this.txtQuebraPX.Name = "txtQuebraPX";
            this.txtQuebraPX.Size = new System.Drawing.Size(85, 26);
            this.txtQuebraPX.TabIndex = 26;
            this.txtQuebraPX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oNovoTab);
            this.txtQuebraPX.Leave += new System.EventHandler(this.txtQuebraPX_Leave);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbRup);
            this.groupBox6.Controls.Add(this.rbLdown);
            this.groupBox6.Controls.Add(this.rbRdown);
            this.groupBox6.Controls.Add(this.rbLup);
            this.groupBox6.Location = new System.Drawing.Point(6, 84);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(153, 100);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            // 
            // rbRup
            // 
            this.rbRup.AutoSize = true;
            this.rbRup.Location = new System.Drawing.Point(77, 19);
            this.rbRup.Name = "rbRup";
            this.rbRup.Size = new System.Drawing.Size(14, 13);
            this.rbRup.TabIndex = 30;
            this.rbRup.UseVisualStyleBackColor = true;
            this.rbRup.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbLdown
            // 
            this.rbLdown.AutoSize = true;
            this.rbLdown.Location = new System.Drawing.Point(6, 68);
            this.rbLdown.Name = "rbLdown";
            this.rbLdown.Size = new System.Drawing.Size(14, 13);
            this.rbLdown.TabIndex = 32;
            this.rbLdown.UseVisualStyleBackColor = true;
            this.rbLdown.CheckedChanged += new System.EventHandler(this.rbLdown_CheckedChanged);
            // 
            // rbRdown
            // 
            this.rbRdown.AutoSize = true;
            this.rbRdown.Location = new System.Drawing.Point(77, 68);
            this.rbRdown.Name = "rbRdown";
            this.rbRdown.Size = new System.Drawing.Size(14, 13);
            this.rbRdown.TabIndex = 29;
            this.rbRdown.UseVisualStyleBackColor = true;
            this.rbRdown.CheckedChanged += new System.EventHandler(this.rbRdown_CheckedChanged);
            // 
            // rbLup
            // 
            this.rbLup.AutoSize = true;
            this.rbLup.Location = new System.Drawing.Point(6, 19);
            this.rbLup.Name = "rbLup";
            this.rbLup.Size = new System.Drawing.Size(14, 13);
            this.rbLup.TabIndex = 31;
            this.rbLup.UseVisualStyleBackColor = true;
            this.rbLup.CheckedChanged += new System.EventHandler(this.rbLup_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(36, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "Angulo e Quebras";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(38, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 20);
            this.label19.TabIndex = 14;
            this.label19.Text = "Angulo";
            // 
            // txtRangulo
            // 
            this.txtRangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRangulo.Location = new System.Drawing.Point(25, 50);
            this.txtRangulo.Name = "txtRangulo";
            this.txtRangulo.Size = new System.Drawing.Size(85, 26);
            this.txtRangulo.TabIndex = 13;
            this.txtRangulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oNovoTab);
            this.txtRangulo.Leave += new System.EventHandler(this.txtRangulo_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.cbResolucao);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Location = new System.Drawing.Point(9, 245);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(207, 86);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Quebras";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(109, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(38, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "S8";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(43, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(38, 17);
            this.radioButton1.TabIndex = 99;
            this.radioButton1.Text = "S4";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oNovoTab);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.btnHole1);
            this.groupBox4.Controls.Add(this.txtHoleP);
            this.groupBox4.Controls.Add(this.cbHole);
            this.groupBox4.Location = new System.Drawing.Point(222, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 86);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Map";
            // 
            // txtHoleP
            // 
            this.txtHoleP.Location = new System.Drawing.Point(6, 55);
            this.txtHoleP.Name = "txtHoleP";
            this.txtHoleP.Size = new System.Drawing.Size(45, 20);
            this.txtHoleP.TabIndex = 96;
            this.txtHoleP.TabStop = false;
            // 
            // cbHole
            // 
            this.cbHole.FormattingEnabled = true;
            this.cbHole.Items.AddRange(new object[] {
            "Blue Lagoon",
            "Pink Wind",
            "West Wiz",
            "Ice Spa",
            "Lost Seaway",
            "Wiz City",
            "Abbot Mine",
            "Shining Sand",
            "Ice Cannon",
            "Eastern Valley",
            "Sepia Wind",
            "Blue Moon",
            "Blue Water",
            "White Wiz",
            "Wind Hill",
            "Deep Inferno",
            "Silvia Cannon",
            "Ice Inferno",
            "Wiz Wiz"});
            this.cbHole.Location = new System.Drawing.Point(6, 19);
            this.cbHole.Name = "cbHole";
            this.cbHole.Size = new System.Drawing.Size(84, 21);
            this.cbHole.TabIndex = 97;
            this.cbHole.TabStop = false;
            this.cbHole.SelectedIndexChanged += new System.EventHandler(this.cbHole_SelectedIndexChanged);
            // 
            // btnHole1
            // 
            this.btnHole1.Location = new System.Drawing.Point(113, 9);
            this.btnHole1.Name = "btnHole1";
            this.btnHole1.Size = new System.Drawing.Size(75, 23);
            this.btnHole1.TabIndex = 95;
            this.btnHole1.TabStop = false;
            this.btnHole1.Text = "<<<";
            this.btnHole1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 94;
            this.button2.TabStop = false;
            this.button2.Text = "<<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 93;
            this.button3.TabStop = false;
            this.button3.Text = "<<<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnWindHill
            // 
            this.btnWindHill.Location = new System.Drawing.Point(319, 19);
            this.btnWindHill.Name = "btnWindHill";
            this.btnWindHill.Size = new System.Drawing.Size(75, 23);
            this.btnWindHill.TabIndex = 36;
            this.btnWindHill.TabStop = false;
            this.btnWindHill.Text = "Wind Hill";
            this.btnWindHill.UseVisualStyleBackColor = true;
            this.btnWindHill.Click += new System.EventHandler(this.btnWindHill_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 561);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(454, 600);
            this.MinimumSize = new System.Drawing.Size(454, 600);
            this.Name = "MainWindow";
            this.Text = "Pangya Interface Calc";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTerreno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSlope;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTacada;
        private System.Windows.Forms.TextBox txtAim475;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSpin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCalliper;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAim4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tipoTacada;
        private System.Windows.Forms.ComboBox cbResolucao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbRup;
        private System.Windows.Forms.RadioButton rbLdown;
        private System.Windows.Forms.RadioButton rbRdown;
        private System.Windows.Forms.RadioButton rbLup;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtRangulo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtQuebra;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtQuebraAngulo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtQuebraPX;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbHole;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.TextBox txtHoleP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHole1;
        private System.Windows.Forms.Button btnWindHill;
    }
}

