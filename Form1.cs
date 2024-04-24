using AC4.Utils;
using AC4.ComarcaDAO;
using AC4;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.Data;
using System.Xml;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        const int YearLimit = 2050, PoblationLimit = 20000;
        ComarcaDAO comarcaDAO = new ComarcaDAO(NpgsqlUtils.OpenConnection());

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anySelector.SelectedIndex = 0;
            comarcaSelector.SelectedIndex = 0;
            poblacioSelector.Text = string.Empty;
            domesticXarxaSelector.Text = string.Empty;
            actEconomiquesSelector.Text = string.Empty;
            consumDomesticSelector.Text = string.Empty;
            totalSelector.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertComarca();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<AC4.Region> regions = comarcaDAO.GetAllRegions();
            LoadDataGrid(regions);
            LoadYears(regions);
            LoadRegionNames(regions);
        }

        private void LoadDataGrid(List<AC4.Region> regions)
        {
            dataGrid.Rows.Clear();
            foreach (AC4.Region region in regions)
            {
                DataGridViewRow row = (DataGridViewRow)dataGrid.Rows[0].Clone();
                row.Cells[0].Value = region.Any;
                row.Cells[1].Value = region.CodiComarca;
                row.Cells[2].Value = region.NomComarca;
                row.Cells[3].Value = region.Poblacio;
                row.Cells[4].Value = region.DomesticXarxa;
                row.Cells[5].Value = region.ActivitatsEconomiques;
                row.Cells[6].Value = region.Total;
                row.Cells[7].Value = region.ConsumDomesticCapita;
                dataGrid.Rows.Add(row);
            }
        }

        private void LoadYears(List<AC4.Region> regions)
        {
            anySelector.Items.Clear();
            anySelector.Items.Add("");
            for (int i = regions.Min(r => r.Any); i <= YearLimit; i++)
            {
                anySelector.Items.Add(i);
            }
        }

        private void LoadRegionNames(List<AC4.Region> regions)
        {
            comarcaSelector.Items.Clear();
            comarcaSelector.Items.Add("");

            List<string> names = regions.Select(x => x.NomComarca).Distinct().ToList();
            foreach (string name in names)
            {
                comarcaSelector.Items.Add(name);
            }
        }

        private List<string> ComarcaNames(string path)
        {
            List<string> names = new List<string>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            XmlNodeList xmlNodeList = xmlDocument.SelectNodes("//NomComarca");
            foreach (XmlElement xmlN in xmlNodeList)
            {
                names.Add(xmlN.InnerText);
            }
            return names.Distinct().ToList();
        }

        private void InsertComarca()
        {
            string nomComarca;
            int anyComarca, codiComarca, poblacio, domesticXarxa, actEconomiques, total;
            double consumDomestic;
            try
            {
                if (anySelector.Text == string.Empty)
                {
                    throw new Exception("Debe elegir un año");
                }
                anyComarca = Convert.ToInt32(anySelector.Text);

                error.SetError(anySelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(anySelector, ex.Message);
                return;
            }

            try
            {
                nomComarca = comarcaSelector.Text;
                if (nomComarca == string.Empty)
                {
                    throw new Exception("Debe elegir una comarca");
                }
                error.SetError(comarcaSelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(comarcaSelector, ex.Message);
                return;
            }

            List<AC4.Region> regions = comarcaDAO.GetAllRegions();
            codiComarca = regions.FirstOrDefault(r => r.NomComarca == nomComarca).CodiComarca;

            try
            {
                poblacio = Convert.ToInt32(poblacioSelector.Text);
                error.SetError(poblacioSelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(poblacioSelector, ex.Message);
                return;
            }
            try
            {
                domesticXarxa = Convert.ToInt32(domesticXarxaSelector.Text);
                error.SetError(domesticXarxaSelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(domesticXarxaSelector, ex.Message);
                return;
            }
            try
            {
                actEconomiques = Convert.ToInt32(actEconomiquesSelector.Text);
                error.SetError(actEconomiquesSelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(actEconomiquesSelector, ex.Message);
                return;
            }
            try
            {
                total = Convert.ToInt32(totalSelector.Text);
                error.SetError(totalSelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(totalSelector, ex.Message);
                return;
            }
            try
            {
                consumDomestic = Convert.ToDouble(consumDomesticSelector.Text);
                error.SetError(consumDomesticSelector, null);
            }
            catch (Exception ex)
            {
                error.SetError(consumDomesticSelector, ex.Message);
                return;
            }

            AC4.Region comarca = new AC4.Region()
            {
                Any = anyComarca,
                CodiComarca = codiComarca,
                NomComarca = nomComarca,
                Poblacio = poblacio,
                DomesticXarxa = domesticXarxa,
                ActivitatsEconomiques = actEconomiques,
                Total = total,
                ConsumDomesticCapita = consumDomestic
            };

            comarcaDAO.AddRegion(comarca);
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];

                List<AC4.Region> regions = comarcaDAO.GetAllRegions();

                poblacioMayor20000.Text = Convert.ToInt32(selectedRow.Cells["Poblacio"].Value.ToString()) > PoblationLimit ? "Sí" : "No";
                domesticMedio.Text = Convert.ToString(Convert.ToInt32(selectedRow.Cells["DomesticXarxa"].Value.ToString()) / Convert.ToInt32(selectedRow.Cells["Poblacio"].Value.ToString()));
                double consumDomestic = Convert.ToDouble(selectedRow.Cells["ConsumDomestic"].Value.ToString());
                domesticMesAlt.Text = consumDomestic >= regions.Max(r => r.ConsumDomesticCapita) ? "Sí" : "No";
                domesticMexBaix.Text = consumDomestic <= regions.Min(r => r.ConsumDomesticCapita) ? "Sí" : "No";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
