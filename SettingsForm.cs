using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StockViewer
{
    public partial class SettingsForm : Form
    {
        Settings settings = Settings.Load(Form1.settings_path);

        public SettingsForm()
        {
            InitializeComponent();
            fontValue.Value = settings.fontSize;
            spaceingValue.Value = settings.nrSpaces;
            opacityValue.Value = settings.opacity;
            speedValue.Value = settings.speed;
            monitorValue.Value = settings.monitor;
            companiesValue.Text = settings.companies;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settings.fontSize = (int)fontValue.Value;
            settings.nrSpaces = (int)spaceingValue.Value;
            settings.opacity = (int)opacityValue.Value;
            settings.speed = (int)speedValue.Value;
            settings.monitor = (int)monitorValue.Value;
            string trimmed = String.Concat(companiesValue.Text.Where(c => !Char.IsWhiteSpace(c)));
            settings.companies = trimmed;

            settings.Save(Form1.settings_path);
        }

        private void monitorValue_ValueChanged(object sender, EventArgs e)
        {
            if (monitorValue.Value > Screen.AllScreens.Length - 1)
                monitorValue.Value = Screen.AllScreens.Length - 1;
        }
    }
}
