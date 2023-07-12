using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static apiWrapper___Example.apiWrapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace apiWrapper___Example
{
    public partial class Form1 : Form
    {
        // Define Wrapper
        apiWrapper xApi = new apiWrapper();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Set API Key
            apiWrapper.apiAuthentication.Key = textBox3.Text;

            groupBox1.Enabled= true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "geoip")
            {
                MessageBox.Show(xApi.doApiCall(APIS.GeoIP, textBox1.Text));
            }
        }
    }
}
