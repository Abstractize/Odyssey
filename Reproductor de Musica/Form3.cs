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
    public partial class Form3 : Form
    {
        private String username;
        private String password;
        
        public Form3()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 player = new Form1(username);
            player.ShowDialog();
            this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }
    }
}
