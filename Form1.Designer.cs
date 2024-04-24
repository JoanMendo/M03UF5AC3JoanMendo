namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            anySelector = new ComboBox();
            comarcaSelector = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            domesticXarxaSelector = new TextBox();
            actEconomiquesSelector = new TextBox();
            label11 = new Label();
            consumDomesticSelector = new TextBox();
            label12 = new Label();
            totalSelector = new TextBox();
            label13 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGrid = new DataGridView();
            Any = new DataGridViewTextBoxColumn();
            CodiComarca = new DataGridViewTextBoxColumn();
            Comarca = new DataGridViewTextBoxColumn();
            Poblacio = new DataGridViewTextBoxColumn();
            DomesticXarxa = new DataGridViewTextBoxColumn();
            ActEconomiques = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ConsumDomestic = new DataGridViewTextBoxColumn();
            poblacioMayor20000 = new Label();
            domesticMedio = new Label();
            domesticMesAlt = new Label();
            domesticMexBaix = new Label();
            groupBox1 = new GroupBox();
            poblacioSelector = new TextBox();
            groupBox2 = new GroupBox();
            error = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.Location = new Point(24, 45);
            label3.Name = "label3";
            label3.Size = new Size(128, 13);
            label3.TabIndex = 2;
            label3.Text = "Població > 20.000 hab.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.Location = new Point(24, 88);
            label4.Name = "label4";
            label4.Size = new Size(132, 13);
            label4.TabIndex = 3;
            label4.Text = "Consum domèstic mitjà:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label5.Location = new Point(24, 134);
            label5.Name = "label5";
            label5.Size = new Size(197, 13);
            label5.TabIndex = 4;
            label5.Text = "Consum domèstic per càpita més alt:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label6.Location = new Point(24, 175);
            label6.Name = "label6";
            label6.Size = new Size(206, 13);
            label6.TabIndex = 5;
            label6.Text = "Consum domèstic per càpita més baix:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label7.Location = new Point(6, 36);
            label7.Name = "label7";
            label7.Size = new Size(28, 13);
            label7.TabIndex = 6;
            label7.Text = "Any";
            // 
            // anySelector
            // 
            anySelector.DropDownStyle = ComboBoxStyle.DropDownList;
            anySelector.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            anySelector.FormattingEnabled = true;
            anySelector.Location = new Point(6, 54);
            anySelector.Name = "anySelector";
            anySelector.Size = new Size(86, 25);
            anySelector.TabIndex = 7;
            // 
            // comarcaSelector
            // 
            comarcaSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            comarcaSelector.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comarcaSelector.FormattingEnabled = true;
            comarcaSelector.Location = new Point(116, 54);
            comarcaSelector.Name = "comarcaSelector";
            comarcaSelector.Size = new Size(165, 25);
            comarcaSelector.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label8.Location = new Point(116, 36);
            label8.Name = "label8";
            label8.Size = new Size(52, 13);
            label8.TabIndex = 8;
            label8.Text = "Comarca";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label9.Location = new Point(306, 36);
            label9.Name = "label9";
            label9.Size = new Size(52, 13);
            label9.TabIndex = 10;
            label9.Text = "Població";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label10.Location = new Point(6, 105);
            label10.Name = "label10";
            label10.Size = new Size(86, 13);
            label10.TabIndex = 12;
            label10.Text = "Domèstic xarxa";
            // 
            // domesticXarxaSelector
            // 
            domesticXarxaSelector.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            domesticXarxaSelector.Location = new Point(6, 133);
            domesticXarxaSelector.Name = "domesticXarxaSelector";
            domesticXarxaSelector.Size = new Size(86, 25);
            domesticXarxaSelector.TabIndex = 13;
            // 
            // actEconomiquesSelector
            // 
            actEconomiquesSelector.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            actEconomiquesSelector.Location = new Point(116, 133);
            actEconomiquesSelector.Name = "actEconomiquesSelector";
            actEconomiquesSelector.Size = new Size(125, 25);
            actEconomiquesSelector.TabIndex = 15;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label11.Location = new Point(116, 96);
            label11.Name = "label11";
            label11.Size = new Size(140, 34);
            label11.TabIndex = 14;
            label11.Text = "Activitats econòmiques i fonts pròpies";
            // 
            // consumDomesticSelector
            // 
            consumDomesticSelector.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            consumDomesticSelector.Location = new Point(306, 133);
            consumDomesticSelector.Name = "consumDomesticSelector";
            consumDomesticSelector.Size = new Size(110, 25);
            consumDomesticSelector.TabIndex = 17;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label12.Location = new Point(306, 96);
            label12.Name = "label12";
            label12.Size = new Size(100, 41);
            label12.TabIndex = 16;
            label12.Text = "Consum domèstic per càpita total";
            // 
            // totalSelector
            // 
            totalSelector.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalSelector.Location = new Point(444, 89);
            totalSelector.Name = "totalSelector";
            totalSelector.Size = new Size(110, 25);
            totalSelector.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label13.Location = new Point(444, 63);
            label13.Name = "label13";
            label13.Size = new Size(32, 13);
            label13.TabIndex = 18;
            label13.Text = "Total";
            label13.Click += label13_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(335, 211);
            button1.Name = "button1";
            button1.Size = new Size(147, 48);
            button1.TabIndex = 20;
            button1.Text = "Netejar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(105, 211);
            button2.Name = "button2";
            button2.Size = new Size(142, 48);
            button2.TabIndex = 21;
            button2.Text = "Persistir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGrid
            // 
            dataGrid.BackgroundColor = SystemColors.Highlight;
            dataGrid.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Info;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Any, CodiComarca, Comarca, Poblacio, DomesticXarxa, ActEconomiques, Total, ConsumDomestic });
            dataGrid.Location = new Point(12, 280);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(817, 150);
            dataGrid.TabIndex = 22;
            dataGrid.SelectionChanged += dataGrid_SelectionChanged;
            // 
            // Any
            // 
            Any.HeaderText = "Any";
            Any.Name = "Any";
            Any.Width = 50;
            // 
            // CodiComarca
            // 
            CodiComarca.HeaderText = "Codi Comarca";
            CodiComarca.Name = "CodiComarca";
            CodiComarca.Width = 60;
            // 
            // Comarca
            // 
            Comarca.HeaderText = "Comarca";
            Comarca.Name = "Comarca";
            Comarca.Width = 110;
            // 
            // Poblacio
            // 
            Poblacio.HeaderText = "Població";
            Poblacio.Name = "Poblacio";
            Poblacio.Width = 110;
            // 
            // DomesticXarxa
            // 
            DomesticXarxa.HeaderText = "Domèstic Xarxa";
            DomesticXarxa.Name = "DomesticXarxa";
            DomesticXarxa.Width = 110;
            // 
            // ActEconomiques
            // 
            ActEconomiques.HeaderText = "A.E. i fonts pròpies";
            ActEconomiques.Name = "ActEconomiques";
            ActEconomiques.Width = 110;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 105;
            // 
            // ConsumDomestic
            // 
            ConsumDomestic.HeaderText = "Consum doméstic/càpita";
            ConsumDomestic.Name = "ConsumDomestic";
            ConsumDomestic.Width = 105;
            // 
            // poblacioMayor20000
            // 
            poblacioMayor20000.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            poblacioMayor20000.BackColor = SystemColors.ControlLight;
            poblacioMayor20000.BorderStyle = BorderStyle.Fixed3D;
            poblacioMayor20000.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            poblacioMayor20000.Location = new Point(175, 38);
            poblacioMayor20000.Name = "poblacioMayor20000";
            poblacioMayor20000.Size = new Size(35, 29);
            poblacioMayor20000.TabIndex = 23;
            poblacioMayor20000.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // domesticMedio
            // 
            domesticMedio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            domesticMedio.BackColor = SystemColors.ControlLight;
            domesticMedio.BorderStyle = BorderStyle.Fixed3D;
            domesticMedio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            domesticMedio.Location = new Point(175, 81);
            domesticMedio.Name = "domesticMedio";
            domesticMedio.Size = new Size(35, 29);
            domesticMedio.TabIndex = 24;
            domesticMedio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // domesticMesAlt
            // 
            domesticMesAlt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            domesticMesAlt.BackColor = SystemColors.ControlLight;
            domesticMesAlt.BorderStyle = BorderStyle.Fixed3D;
            domesticMesAlt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            domesticMesAlt.Location = new Point(240, 126);
            domesticMesAlt.Name = "domesticMesAlt";
            domesticMesAlt.Size = new Size(35, 29);
            domesticMesAlt.TabIndex = 25;
            domesticMesAlt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // domesticMexBaix
            // 
            domesticMexBaix.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            domesticMexBaix.BackColor = SystemColors.ControlLight;
            domesticMexBaix.BorderStyle = BorderStyle.Fixed3D;
            domesticMexBaix.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            domesticMexBaix.Location = new Point(240, 168);
            domesticMexBaix.Name = "domesticMexBaix";
            domesticMexBaix.Size = new Size(35, 29);
            domesticMexBaix.TabIndex = 26;
            domesticMexBaix.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(poblacioSelector);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(anySelector);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comarcaSelector);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(domesticXarxaSelector);
            groupBox1.Controls.Add(totalSelector);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(actEconomiquesSelector);
            groupBox1.Controls.Add(consumDomesticSelector);
            groupBox1.Controls.Add(label12);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.Location = new Point(6, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 183);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demogràfiques de regions";
            // 
            // poblacioSelector
            // 
            poblacioSelector.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            poblacioSelector.Location = new Point(306, 54);
            poblacioSelector.Name = "poblacioSelector";
            poblacioSelector.Size = new Size(110, 25);
            poblacioSelector.TabIndex = 20;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(domesticMexBaix);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(domesticMesAlt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(domesticMedio);
            groupBox2.Controls.Add(poblacioMayor20000);
            groupBox2.Font = new Font("Segoe UI", 14F);
            groupBox2.Location = new Point(592, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 219);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadístiques";
            // 
            // error
            // 
            error.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            error.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(896, 448);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGrid);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Gestió de dades demogràfiques de regions";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox anySelector;
        private ComboBox comarcaSelector;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox domesticXarxaSelector;
        private TextBox actEconomiquesSelector;
        private Label label11;
        private TextBox consumDomesticSelector;
        private Label label12;
        private TextBox totalSelector;
        private Label label13;
        private Button button1;
        private Button button2;
        private DataGridView dataGrid;
        private Label poblacioMayor20000;
        private Label domesticMedio;
        private DataGridViewTextBoxColumn Any;
        private DataGridViewTextBoxColumn CodiComarca;
        private DataGridViewTextBoxColumn Comarca;
        private DataGridViewTextBoxColumn Poblacio;
        private DataGridViewTextBoxColumn DomesticXarxa;
        private DataGridViewTextBoxColumn ActEconomiques;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn ConsumDomestic;
        private Label domesticMesAlt;
        private Label domesticMexBaix;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox poblacioSelector;
        private ErrorProvider error;
    }
}
