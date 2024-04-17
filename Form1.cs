using System.Data;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            dataTable = new DataTable();
            showCSVInDataTable();
            addYearsToComboBox();
            addComarcasFromCSV();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void addYearsToComboBox()
        {
            for (int i = 2050; i >= 2012; i--)
            {
                comboBox1.Items.Add(i);
            }
        }
        private void addComarcasFromCSV()
        {
            string filePath = "../../../ConsumAigua.csv";
            List<string> comarcas = new List<string>();
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        reader.ReadLine();
                        while (!reader.EndOfStream)
                        {
                            string[] fields = reader.ReadLine().Split(',');
                            if (!comarcas.Contains(fields[2]))
                            {
                                comarcas.Add(fields[2]);
                            }
                        }
                    }
                    foreach (string comarca in comarcas)
                    {
                        comboBox2.Items.Add(comarca);
                    }
                }
                else
                {
                    MessageBox.Show("CSV file not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private int[] showCSVInDataTable()
        {
            dataGridView1.DataSource = null;
            dataTable.Clear();

            int max = 0;
            int min = 1000000;
            string filePath = "../../../ConsumAigua.csv";

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string[] headers = reader.ReadLine().Split(',');

                        foreach (string header in headers)
                        {
                            dataTable.Columns.Add(header);
                        }

                        while (!reader.EndOfStream)
                        {
                            string[] fields = reader.ReadLine().Split(',');
                            if (fields.Length != headers.Length)
                            {
                                string[] newFields = { fields[0], fields[1], fields[2] + fields[3], fields[4], fields[5], fields[6], fields[7], fields[8] };
                                dataTable.Rows.Add(newFields);
                                if (Convert.ToInt32(newFields[4]) / Convert.ToInt32(newFields[3]) > max)
                                {
                                    max = Convert.ToInt32(newFields[4]) / Convert.ToInt32(newFields[3]);
                                }
                                if (Convert.ToInt32(newFields[4]) / Convert.ToInt32(newFields[3]) < min)
                                {
                                    min = Convert.ToInt32(newFields[4]) / Convert.ToInt32(newFields[3]);
                                }
                            }
                            else
                            {
                                dataTable.Rows.Add(fields);

                                if (Convert.ToInt32(fields[4]) / Convert.ToInt32(fields[3]) > max)
                                {
                                    max = Convert.ToInt32(fields[4]) / Convert.ToInt32(fields[3]);
                                }
                                if (Convert.ToInt32(fields[4]) / Convert.ToInt32(fields[3]) < min)
                                {
                                    min = Convert.ToInt32(fields[4]) / Convert.ToInt32(fields[3]);
                                }
                            }
                                
                        }
                    }

                    dataGridView1.DataSource = dataTable;
                    int[] range = { min, max };
                    return range;
                }
                else
                {
                    MessageBox.Show("CSV file not found.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
        }


        private void clearParametersOfText(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }


        private void SaveResult(object sender, EventArgs e)
        {
            string filePath = "../../../ConsumAigua.csv";
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine(comboBox1.Text + "," + comboBox2.SelectedIndex + "," + comboBox2.Text + "," + textBox1.Text + "," + textBox3.Text + "," + textBox2.Text + "," + (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox2.Text)) + "," + (Convert.ToInt32(textBox3.Text) / Convert.ToInt32(textBox1.Text)));
                    }
                    dataTable.Rows.Add(comboBox1.Text, comboBox2.TabIndex, comboBox2.Text, textBox1.Text, textBox3.Text, textBox2.Text, (Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox2.Text)), (Convert.ToInt32(textBox3.Text) / Convert.ToInt32(textBox1.Text)));
                    clearParametersOfText(sender, e);
                }
                else
                {
                    MessageBox.Show("CSV file not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DataGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                label6.Text = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value) > 20000 ? "Població > 20000 : Si" : "Població > 20000 : No";
                label7.Text = "Consum domèstic mitja: " + (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value) / Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value)).ToString();
                int[] range = getHighestAndLowest();
                label8.Text = "Màxim consum domèstic mitja: " + (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value) == range[1] ? "Si" : "No");
                label9.Text = "Mínim consum domèstic mitja: " + (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value) == range[0] ? "Si" : "No");


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            
        }
        private int[] getHighestAndLowest()
        {
            int max = 0;
            int min = 1000000;
            string filePath = "../../../ConsumAigua.csv";

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string[] headers = reader.ReadLine().Split(',');

                        

                        while (!reader.EndOfStream)
                        {
                            string[] fields = reader.ReadLine().Split(',');
                            if (fields.Length != headers.Length)
                            {
                                string[] newFields = { fields[0], fields[1], fields[2] + fields[3], fields[4], fields[5], fields[6], fields[7], fields[8] };
                               
                                if (Convert.ToInt32(newFields[4]) / Convert.ToInt32(newFields[3]) > max)
                                {
                                    max = Convert.ToInt32(newFields[4]) / Convert.ToInt32(newFields[3]);
                                }
                                if (Convert.ToInt32(newFields[4]) / Convert.ToInt32(newFields[3]) < min)
                                {
                                    min = Convert.ToInt32(newFields[4]) / Convert.ToInt32(newFields[3]);
                                }
                            }
                            else
                            {
                               

                                if (Convert.ToInt32(fields[4]) / Convert.ToInt32(fields[3]) > max)
                                {
                                    max = Convert.ToInt32(fields[4]) / Convert.ToInt32(fields[3]);
                                }
                                if (Convert.ToInt32(fields[4]) / Convert.ToInt32(fields[3]) < min)
                                {
                                    min = Convert.ToInt32(fields[4]) / Convert.ToInt32(fields[3]);
                                }
                            }

                        }
                    }

                    int[] range = { min, max };
                    return range;
                }
                else
                {
                    MessageBox.Show("CSV file not found.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
            }
        }
    }
}
