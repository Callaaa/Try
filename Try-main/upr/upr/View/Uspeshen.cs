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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void Uspeshen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.database1DataSet.Admin);
            // TODO: This line of code loads data into the 'database1DataSet.Gallery' table. You can move, or remove it, as needed.
            this.galleryTableAdapter.Fill(this.database1DataSet.Gallery);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
