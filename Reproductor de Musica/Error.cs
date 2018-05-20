using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_de_Musica
{
    public partial class Error : Form
    {
        public Error(String label)
        {
            InitializeComponent();
            label1.Text = label;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
