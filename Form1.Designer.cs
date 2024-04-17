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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 56);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "Any";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(2, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 299);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demogràfiques de regions";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 176);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 10;
            label5.Text = "Domèstic Xarxa";
            // 
            // label4
            // 
            label4.Location = new Point(372, 167);
            label4.Name = "label4";
            label4.Size = new Size(160, 39);
            label4.TabIndex = 9;
            label4.Text = "Activitats econòmiques i fonts pròpies";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 176);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Població";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 56);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Comarca";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(294, 83);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(196, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(379, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 330);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(908, 275);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += DataGridCellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(588, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 169);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadìstiques";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 129);
            label9.Name = "label9";
            label9.Size = new Size(206, 15);
            label9.TabIndex = 14;
            label9.Text = "Consúm domèstic per capita més alt: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 91);
            label8.Name = "label8";
            label8.Size = new Size(206, 15);
            label8.TabIndex = 13;
            label8.Text = "Consúm domèstic per capita més alt: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 56);
            label7.Name = "label7";
            label7.Size = new Size(141, 15);
            label7.TabIndex = 12;
            label7.Text = "Consum Domèstic mitja: ";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 21);
            label6.Name = "label6";
            label6.Size = new Size(151, 15);
            label6.TabIndex = 11;
            label6.Text = "Població > 20000 Habitants";
            // 
            // button1
            // 
            button1.Location = new Point(588, 206);
            button1.Name = "button1";
            button1.Size = new Size(90, 38);
            button1.TabIndex = 6;
            button1.Text = "Netejar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += clearParametersOfText;
            // 
            // button2
            // 
            button2.Location = new Point(588, 250);
            button2.Name = "button2";
            button2.Size = new Size(90, 40);
            button2.TabIndex = 7;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SaveResult;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 617);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private Button button1;
        private Button button2;
    }
}
