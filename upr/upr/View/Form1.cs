using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using upr.View;

namespace upr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            log_in1.Hide();
            registration1.Hide();
            about_us1.Hide();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void галерияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var gallery = new Gallery();
            gallery.Closed += (s, args) => this.Close();
            gallery.Show();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var contact = new Contact();
            contact.Closed += (s, args) => this.Close();
            contact.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log_in1.Hide();         
            registration1.Hide();
            about_us1.Hide();
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log_in1.Hide();
            about_us1.BringToFront();
            registration1.Hide();
            about_us1.Show();
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log_in1.Hide();
            registration1.Hide();
            about_us1.Hide();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log_in1.Show();
            log_in1.BringToFront();
            registration1.Hide();
            about_us1.Hide();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log_in1.Hide();
            registration1.BringToFront();
            registration1.Show();
            about_us1.Hide();
        }
    }
}
