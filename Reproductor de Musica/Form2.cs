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
    
    public partial class Form2 : Form
    {
        private String songName, songArtist, songAlbum, index, year;
        private Boolean sync;
        //Getters and Setters
        public string SongName { get => songName; set => songName = value; }
        public string SongArtist { get => songArtist; set => songArtist = value; }
        public string SongAlbum { get => songAlbum; set => songAlbum = value; }
        public string Index { get => index; set => index = value; }
        public string Year { get => year; set => year = value; }
        public bool Sync { get => sync; set => sync = value; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void update(String Name, String art, String song, String i, String year)
        {
            textBox1.Text = Name;
            textBox2.Text = art;
            textBox3.Text = song;
            textBox4.Text = i;
            textBox5.Text = year;
        }
        //Buttons and labels
        private void button1_Click(object sender, EventArgs e)
        {
            songName = textBox1.Text;
            songArtist = textBox2.Text;
            songAlbum = textBox3.Text;
            index = textBox4.Text;
            year = textBox5.Text;
            this.Close();
        }
        public Form2()
        {
            InitializeComponent();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked){
                sync = true;
            }
            else
            {
                sync = false;
            }

        }
        
    }
}
