using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f = 0;
            try
            {
                f = float.Parse(txt_farenheit.Text);

            }
            catch
            {
                MessageBox.Show("Only Input Numbers");
            }

            float c = 5f / 9 * (f - 32);
         
            float k = c + 273.15f;

            // {variable,padding:format}
            txt_celsius.Text = $"{c:0.000}"; // *String Interpolation* :)

            
            txt_Kelvin.Text = $"{k:0.000}";

            //txt_Kelvin.Text = k.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture);
          
        }
    }
}
