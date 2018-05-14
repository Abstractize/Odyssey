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
    public partial class Form1 : Form
    {
        bool Play = false;
        
        List MP3Files = new List();
        List MP3FilesDirectory = new List();

        public Form1()
        {
            InitializeComponent();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addFileToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog SearchBox = new OpenFileDialog();
            SearchBox.Multiselect = true;
            if (SearchBox.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach(var name in SearchBox.SafeFileNames)
                {
                    MP3Files.add(name);
                }
                foreach (var name in SearchBox.FileNames)
                {
                    MP3FilesDirectory.add(name);
                }
                lstSongs.Items.Clear();        
                for(int i = 0; i<MP3Files.getLength(); i++)
                {
                    string song = MP3Files.getValue(i);
                    lstSongs.Items.Add(song);
                }
                

               

                //Player.URL = MP3Files[0];
                //lstSongs.SelectedIndex = 0;
            }
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = MP3FilesDirectory.getValue(lstSongs.SelectedIndex);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            lstSongs.Visible = true;
        }
    }
}
