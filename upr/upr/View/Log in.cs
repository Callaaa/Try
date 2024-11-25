using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upr.View
{
    public partial class Log_in : UserControl
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Press" && textBox2.Text == "123")
            {
                var admin = new Admin_Login();
                admin.Closed += (s, args) => this.Hide();
                admin.Show();
            }
            else
            {
                MessageBox.Show("greshni danni");
            }
        }
    }
}
