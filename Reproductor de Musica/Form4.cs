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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
            checkedListBox1.MultiColumn = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String Username = textBox1.Text;
                String fullname = (textBox2.Text + " " + textBox3.Text);
                String age = textBox4.Text;
                int ageNum = Convert.ToInt32(age);
                StringList genres = new StringList();
                foreach (int genreindex in checkedListBox1.CheckedIndices)
                {
                    genres.add(checkedListBox1.CheckedItems[genreindex].ToString());
                }



                this.Close();
            }
            catch{

            }
        }
    }
}
