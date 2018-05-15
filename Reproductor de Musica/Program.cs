using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Reproductor_de_Musica
{
    static class Program
    {
        const int PORT_NO = 10578;
        const string SERVER_IP = "127.0.0.1";
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
       [STAThread]
        static void Main(string[] args)
        {
            Thread playerThread = new Thread(new ThreadStart(startGUI));
            Thread clientThread = new Thread(new ThreadStart(connect));
            playerThread.Start();
            clientThread.Start();
            
        }
        public static void connect()
        {
            
            
                //---data to send to the server---
                string textToSend = "hola";

                //---create a TCPClient object at the IP and port no.---
                TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
                NetworkStream nwStream = client.GetStream();
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

                //---send the text---
                Console.WriteLine("Sending : " + textToSend);
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
         

                //---read back the text---
                byte[] bytesToRead = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
                Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
                Console.ReadLine();
                client.Close();
            
        }

        public static void startGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
