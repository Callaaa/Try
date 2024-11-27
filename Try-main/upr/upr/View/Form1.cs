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
          
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            UsAbput about = new UsAbput();
            this.Controls.Add(about);
            about.Location = new Point(0, 27);
            about.Size = new Size(584, 436);
            about.Show();
            about.BringToFront();           
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log_in login = new Log_in();
            this.Controls.Add(login);
            login.Location = new Point(0, 27);
            login.Size = new Size(584, 436);
            login.Show();
            login.BringToFront();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Registration registrate = new Registration();
            this.Controls.Add(registrate);
            registrate.Location = new Point(0, 27);
            registrate.Size = new Size(584, 436);
            registrate.Show();
            registrate.BringToFront();
        }
    }
}
