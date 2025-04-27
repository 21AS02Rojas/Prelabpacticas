using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prelabpacticas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 cambio1 = new Form2();
            cambio1.Show();
            this.Hide();
        }
    }
}
