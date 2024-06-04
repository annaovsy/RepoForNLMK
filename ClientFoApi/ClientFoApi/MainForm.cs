using Microsoft.VisualBasic.Logging;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;

namespace ClientForApi
{
    public partial class MainForm : Form
    {
        private string? Path { get; set; }
        private int Dividend { get; set; }
        private int Divider { get; set; }

        public MainForm()
        {
            InitializeComponent();
            groupBox.Dock = DockStyle.Left;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox? temp = sender as TextBox;
            if (temp?.Text.Length > 0)
                if (System.Convert.ToInt32(temp.Text) > 10000)
                {
                    MessageBox.Show("Введите значения от 0 до 10000!");
                    temp.Text = "1";
                }
        }

        private void dividerTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox? temp = sender as TextBox;
            if (temp.Text == "0")
            {
                MessageBox.Show("Делитель не может быть равен 0!");
                temp.Text = "";
            }
            else if (temp?.Text.Length > 0)
            {
                if (System.Convert.ToInt32(temp.Text) > 10000)
                {
                    MessageBox.Show("Введите значения от 0 до 10000!");
                    temp.Text = "1";
                }
            }
        }

        private void GetConfiguration()
        {
            try
            {
                ConnectionApiConfigSection section = (ConnectionApiConfigSection)ConfigurationManager.GetSection("StartupConnectionApi");
                for (int i = 0; i < section.CStringItems.Count; i++)
                {
                    if (section.CStringItems[i].Type == Constants.HostType)
                        Path = section.CStringItems[i].Path;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<string> ConnectionToApi()
        {
            using (var client = new HttpClient())
            {
                string path = Path + Constants.ControllerName + "/" + Dividend + "/" + Divider;
                HttpResponseMessage response = await client.GetAsync(path);
                 
                if(response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        private async void calculationButton_Click(object sender, EventArgs e)
        {            
            if (!string.IsNullOrEmpty(dividendTextBox.Text) && !string.IsNullOrEmpty(dividerTextBox.Text))
            {
                Dividend = Convert.ToInt32(dividendTextBox.Text);
                Divider = Convert.ToInt32(dividerTextBox.Text);

                dividendTextBox.Enabled = false;
                dividerTextBox.Enabled = false;
                processPictureBox.Show();
                try
                {                   
                    GetConfiguration();
                    string callResult = await ConnectionToApi();                    
                    quotientTextBox.Text = callResult;                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Во время обращения к веб-службе произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                processPictureBox.Hide();
                dividendTextBox.Enabled = true;
                dividerTextBox.Enabled = true;
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }

    }
}
