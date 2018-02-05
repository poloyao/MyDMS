using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.label1.Text = "enabled";

            await Task.Delay(3000);

            this.button1.Enabled = true;
            this.label1.Text = "True";
        }
    }
}
