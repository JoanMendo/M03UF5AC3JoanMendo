using System.Data;

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
        private void showCSVInDataTable()
        {

            dataTable.Clear();
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
                            }
                            else
                            dataTable.Rows.Add(fields);

                        }
                    }

                    dataGridView1.DataSource = dataTable;
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
    }
}
