﻿using System;
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
        private Client toServer;
        
        public String getUsername()
        {
            return this.username;
        }
        public Form3(Client client)
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            toServer = client;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (toServer.verifyUsername(username, password))
            {
                this.Close();
            }
            else
            {
                Error error = new Error("User not found or Wrong Password");
                error.ShowDialog();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 registry =new Form4();
            registry.ShowDialog();
        }
    }
}
