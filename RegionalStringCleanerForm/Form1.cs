using RegionalStringCleaner.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace RegionalStringCleanerForm
{
    public partial class Form1 : Form
    {
        private RegionalStringCleaner.RegionalStringCleaner _regionalStringCleaner;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add(RegionalStringCleaner.Models.Region.Epc);
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _regionalStringCleaner = new RegionalStringCleaner.RegionalStringCleaner((Region)comboBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var textToClean = txtStringToClean.Text;

            var result = _regionalStringCleaner.CleanString(textToClean);

            txtResult.Text = result;
        }
    }
}
